using esewa_market.Data;
using esewa_market.Data.Dto.Request;
using esewa_market.Data.Dto.Response;
using esewa_market.Data.Entities;
using esewa_market.Services.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace esewa_market.Services.Implementations;

public class OrderService(
    AppDbContext db,
    IUserService userService,
    IProductService productService
) : IOrderService
{

    public async Task<OrderResponse> CreateOrder(string firebaseUid, CreateOrderRequest request)
    {
        var user = await userService.GetCurrentUser(firebaseUid);
        if (user is null) throw new KeyNotFoundException("User not found");

        var requestedItems = request
            .Items
            .GroupBy(i => i.ProductId)
            .Select(x => new
            {
                ProductId = x.Key,
                Quantity = x.Sum(i => i.Quantity)
            })
            .ToList();

        var productIds = requestedItems
            .Select(i => i.ProductId)
            .ToList();

        var products = await db.Products
            .Where(p => productIds.Contains(p.Id))
            .ToDictionaryAsync(x => x.Id);

        if (products.Count != productIds.Count) throw new Exception("Some products not found");
        var orderItems = requestedItems
            .Select(item =>
            {
                var product = products[item.ProductId];
                return new OrderItems
                {
                    ProductId = product.Id,
                    Quantity = item.Quantity,
                    Price = product.Price
                };
            })
            .ToList();

        var subtotal = orderItems.Sum(i => i.Price * i.Quantity);
        var deliveryCharge = 200;
        var discount = 0;

        if (!string.IsNullOrWhiteSpace(request.Promocode))
        {
            if (request.Promocode is "ESEWA10" or "ESEWA20" or "ESEWA30")
            {
                discount = 200;
            }
        }

        var totalPrice = subtotal + deliveryCharge - discount;

        var order = new Order
        {
            UserId = user.Id,
            Address = request.Address.Trim(),
            Phone = request.Phone.Trim(),
            PaymentOption = request.PaymentOption,
            Promocode = request.Promocode,
            IsPromocodeApplied = discount > 0,
            DeliveryCharge = deliveryCharge,
            VehicleNumber = "BA 98 PA 5438",
            Discount = discount,
            TotalPrice = totalPrice,
            OrderItems = orderItems,
            Status = "Initialized",
            PaymentStatus = "Pending"
        };
        try
        {
            db.Orders.Add(order);
            await db.SaveChangesAsync();
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
            Console.WriteLine(ex.InnerException?.Message);
            throw new Exception(ex.Message);
        }


        return new OrderResponse
        {
            Id = order.Id,
            Address = order.Address,
            Phone = order.Phone,
            PaymentOption = order.PaymentOption,
            DeliveryCharge = order.DeliveryCharge,
            TotalPrice = order.TotalPrice,
            Discount = order.Discount,
            Status = order.Status,
            OrderDate = order.OrderDate,
            VehicleNumber = order.VehicleNumber,
            OrderItems = orderItems.Select(i => new OrderItemResponse
            {
                ProductId = i.ProductId,
                ProductName = products[i.ProductId].Name,
                ProductImage = products[i.ProductId].ImageUrls.FirstOrDefault(),
                Brand = products[i.ProductId].Brand,
                Quantity = i.Quantity,
                Price = i.Price
            }).ToList()
        };
    }

    async Task<OrderResponse?> IOrderService.GetOrderById(int id, string firebaseUid)
    {
        var user = await userService.GetCurrentUser(firebaseUid);
        if (user is null) throw new KeyNotFoundException("User not found");

        return await db.Orders
            .AsNoTracking()
            .Where(o => o.Id == id && o.UserId == user.Id)
            .Select(o => new OrderResponse
            {
                Id = o.Id,
                Address = o.Address,
                Phone = o.Phone,
                PaymentOption = o.PaymentOption,
                VehicleNumber = o.VehicleNumber,
                DeliveryCharge = o.DeliveryCharge,
                Discount = o.Discount,
                Status = o.Status,
                TotalPrice = o.TotalPrice,
                OrderDate = o.OrderDate,
                OrderItems = o.OrderItems.Select(i => new OrderItemResponse
                {
                    ProductId = i.ProductId,
                    ProductName = i.Product.Name,
                    Quantity = i.Quantity,
                    Price = i.Price
                }).ToList()
            })
            .FirstOrDefaultAsync();
    }

    public async Task<List<OrderResponse>> GetOrdersByUserId(
        OrdersFilter filter,
        string firebaseUid
    )
    {
        var user = await userService.GetCurrentUser(firebaseUid);
        if (user is null) throw new KeyNotFoundException("User not Found");

        var query = db.Orders
            .AsNoTracking()
            .Where(o => o.UserId == user.Id);

        query = filter switch
        {
            OrdersFilter.All => query,
            OrdersFilter.Pending => query.Where(o =>
                o.Status == "Initialized" || o.Status == "Pending"),
            OrdersFilter.Cancelled => query.Where(o =>
                o.Status == "Cancelled"),
            _ => query
        };

        return await query
            .AsNoTracking()
            .OrderBy(o => o.OrderDate)
            .Select(o => new OrderResponse
                {
                    Id = o.Id,
                    Address = o.Address,
                    Phone = o.Phone,
                    PaymentOption = o.PaymentOption,
                    VehicleNumber = o.VehicleNumber,
                    DeliveryCharge = o.DeliveryCharge,
                    Discount = o.Discount,
                    Status = o.Status,
                    TotalPrice = o.TotalPrice,
                    OrderDate = o.OrderDate,
                    OrderItems = o.OrderItems.Select(i => new OrderItemResponse
                    {
                        ProductId = i.ProductId,
                        ProductName = i.Product.Name,
                        ProductImage = i.Product.ImageUrls.FirstOrDefault(),
                        Brand = i.Product.Brand,
                        Quantity = i.Quantity,
                        Price = i.Price
                    }).ToList()
                }
            ).ToListAsync();
    }

    public async Task<OrderResponse?> UpdateOrderStatus(int id, string firebaseUid, string status)
    {
        var user = await userService.GetCurrentUser(firebaseUid);
        if (user is null) throw new KeyNotFoundException("User not found");

        var order = await db
            .Orders
            .Include(o => o.OrderItems)
            .ThenInclude(i => i.Product)
            .FirstOrDefaultAsync(o => o.Id == id && o.UserId == user.Id);

        if (order is null) return null;

        var allowedStatuses = new[]
        {
            "Initialized",
            "Pending",
            "Processing",
            "Shipped",
            "Delivered",
            "Cancelled"
        };

        var validStatus =
            allowedStatuses.FirstOrDefault(x => x.Equals(status, StringComparison.OrdinalIgnoreCase)
            );

        if (validStatus is null) throw new ArgumentException("Invalid status");

        order.Status = validStatus;
        await db.SaveChangesAsync();

        return new OrderResponse
        {
            Id = order.Id,
            Address = order.Address,
            Phone = order.Phone,
            PaymentOption = order.PaymentOption,
            DeliveryCharge = order.DeliveryCharge,
            Discount = order.Discount,
            Status = validStatus,
            TotalPrice = order.TotalPrice,
            VehicleNumber = order.VehicleNumber,
            OrderDate = order.OrderDate,
            OrderItems = order.OrderItems.Select(i => new OrderItemResponse
            {
                ProductId = i.ProductId,
                ProductName = i.Product.Name,
                ProductImage = i.Product.ImageUrls.FirstOrDefault(),
                Brand = i.Product.Brand,
                Quantity = i.Quantity,
                Price = i.Price
            }).ToList()
        };
    }


}
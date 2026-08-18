using FirebaseAdmin.Auth;

namespace esewa_market.Middlewares;

public class FirebaseAuthMiddleware(RequestDelegate next)
{

    public async Task InvokeAsync(HttpContext context)
    {
        var authorizationHeader = context.Request.Headers.Authorization.ToString();
        if (string.IsNullOrWhiteSpace(authorizationHeader) ||
            !authorizationHeader.StartsWith("Bearer ",
                StringComparison.OrdinalIgnoreCase))
        {
            context.Response.StatusCode = StatusCodes.Status401Unauthorized;
            return;
        }

        var idToken = authorizationHeader["Bearer".Length..].Trim();

        try
        {
            var decodedToken = await FirebaseAuth.DefaultInstance.VerifyIdTokenAsync(idToken);
            context.Items["FirebaseUid"] = decodedToken.Uid;
            context.Items["Email"] = decodedToken.Claims.GetValueOrDefault("email")?.ToString();
            await next(context);
        }
        catch (FirebaseAuthException)
        {
            context.Response.StatusCode = StatusCodes.Status401Unauthorized;
        }
    }

}
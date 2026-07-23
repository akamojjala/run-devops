using System.Runtime.CompilerServices;

namespace Shopping.Client.Startup
{
    public static class HttpMiddleware
    {
        public static IServiceCollection AddHttpMiddleware(this IServiceCollection services)
        {
            services.AddHttpClient("ShoppingAPIClient", client =>
            {
                client.BaseAddress = new Uri("http://localhost:5022");
            });
            return services;
        }
    }
}

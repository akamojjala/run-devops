namespace Shopping.Client.Startup
{
    public static class HttpMiddleware
    {
        public static IServiceCollection AddHttpMiddleware(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddHttpClient("ShoppingAPIClient", client =>
            {
                client.BaseAddress = new Uri(configuration["APIConfig:BaseAddress"]);
            });
            return services;
        }
    }
}

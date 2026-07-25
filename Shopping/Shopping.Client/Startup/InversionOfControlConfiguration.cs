namespace Shopping.Client.Startup
{
    using Scrutor;
    using Shopping.Client.Data;

    public static class InversionOfControlConfiguration
    {
        public static IServiceCollection ConfigureInversionOfControl(this IServiceCollection services)
        {
            services.Scan(scan => scan
                .FromAssemblies(typeof(InversionOfControlConfiguration).Assembly)
                .AddClasses()
                .AsMatchingInterface()
                .WithTransientLifetime());
            return services;
        }
    }
}

using AirFiberChildBuildingsRFS;
using AirFiberChildBuildingsRFS.DAL;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Configuration;

class Program
{
    static void Main(string[] args)
    {
        var configuration = new ConfigurationBuilder()
    .SetBasePath(Directory.GetCurrentDirectory())
    .AddJsonFile("appsettings.json", optional: true)
    .Build();

        // Create a service collection
        var serviceProvider = new ServiceCollection()
            .AddTransient<IDataLayer, DataLayer>() // Add your services here
            .AddSingleton<IConfiguration>(configuration)
            .BuildServiceProvider();

        // Resolve the service you need
        var service = serviceProvider.GetRequiredService<IDataLayer>();

        // Use the service
        service.GetData();

        // Dispose of the service provider when done (if necessary)
        serviceProvider.Dispose();
    }
}

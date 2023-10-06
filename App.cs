using AirFiberChildBuildingsRFS.DAL;
using Microsoft.Extensions.Configuration;

namespace AirFiberChildBuildingsRFS;

public class App
{
    private readonly IDataLayer _dalLayer;
    private readonly IConfiguration _configuration;
    
    public App(IDataLayer dalLayer, IConfiguration configuration)
    {
        _dalLayer = dalLayer;
        _configuration = configuration;
    }

    public void Run(string[] args)
    {
        // version settings
        
        // ApiSettings sections
        var apiSettings = _configuration.GetRequiredSection("ApiSettings");
        Console.WriteLine("Github token ");
        
        _dalLayer.GetData();
    }
}
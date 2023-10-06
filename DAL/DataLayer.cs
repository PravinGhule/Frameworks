using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using AirFiberChildBuildingsRFS;

namespace AirFiberChildBuildingsRFS.DAL
{
    public class DataLayer : IDataLayer
    {
        private readonly IConfiguration _configuration;

        public DataLayer(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public void GetData(){
            var conf = _configuration;
            Console.WriteLine(conf.GetSection("Message").Value);
            Console.WriteLine("Hii");
        }
    }
}
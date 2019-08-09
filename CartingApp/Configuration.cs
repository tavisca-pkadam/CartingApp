using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Threading.Tasks.Dataflow;

namespace CartingApp
{
    public class Configuration
    { 
        
        public static double GetConfigurationDiscount()
        {
           
                var builder = new ConfigurationBuilder()
               .SetBasePath(Directory.GetCurrentDirectory())
     .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);

                IConfigurationRoot configuration = builder.Build();
                int discountOut = 0;
                int.TryParse(configuration.GetConnectionString("discount"), out discountOut);
            
           

            return discountOut;
        }
    }
}
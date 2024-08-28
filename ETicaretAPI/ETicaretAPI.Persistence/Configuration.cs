using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETicaretAPI.Persistence
{
    static class Configuration
    {
        static public string ConnectionString
        {
            get
            {
                var builder = new ConfigurationBuilder().AddJsonFile("appsettings.json",false,false);
                var config = builder.Build();
                return config.GetConnectionString("PostgreSQL");

            }
        }
    }
}

﻿
using Microsoft.Extensions.Configuration;

namespace CodeFirst
{
    public class Initializer
    {
        public static IConfigurationRoot Configuration;
    
        public static void Initialize()
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);
            Configuration = builder.Build();
        }
    }
}

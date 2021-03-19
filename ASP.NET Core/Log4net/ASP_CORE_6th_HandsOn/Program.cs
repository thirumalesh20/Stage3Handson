using ASP_CORE_6th_HandsOn.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASP_CORE_6th_HandsOn
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var host= CreateHostBuilder(args).Build();
            var logger = host.Services.GetRequiredService<ILoggerManager>();
            logger.LogInformation("Starting host application");
            host.Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}

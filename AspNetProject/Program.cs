using AspNetProject.Data;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AspNetProject.Models;

namespace AspNetProject
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var host = CreateHostBuilder(args).Build();
            CreateDbifNotExist(host);
            host.Run();
        }

        private static void CreateDbifNotExist(IHost host)
        {
            using(var scope = host.Services.CreateScope())
            {
                var services = scope.ServiceProvider;

                try
                {
                    var context = services.GetRequiredService<AspNetProjectContext>();
                    context.Attendee.RemoveRange(context.Attendee);
                    context.Attendee.Add(new Attendee { UserName = "Bjorn", Email = "bjornstromberg@codic.se", PhoneNumber = "0700-000000" });
                    context.SaveChanges();

                }
                catch (Exception sten)
                {
                    var logger = services.GetRequiredService<ILogger<Program>>();
                    logger.LogError(sten, "Yalla bror");
                }
            }
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}

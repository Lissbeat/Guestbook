using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using assignment_3.Data;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace assignment_3
{
    public class Program
    {
        public static void Main(string[] args)
        {

    var host = CreateWebHostBuilder(args).Build();
            using (var scope= host.Services.CreateScope()) //lager et scope som begrenser levetiden til en variabel 
        {
            var services = scope.ServiceProvider; 
            var context= services.GetRequiredService<StoreDbContext>();
            StoreDbInitializer.Initilaizer(context); 

        }
            
        host.Run();//vil kjøre en database før applikasjonene kjører
    }
 

        public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .UseStartup<Startup>();
    }
}

using System;
using System.Collections.Generic;
using System.IO;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;

namespace WeatherMicroservice
{
    public class Program
    {
        public static void Main(string[] args)
        {
            BuildWebHost(args).Run();
        }

        public static IWebHost BuildWebHost(string[] args) =>

            WebHost.CreateDefaultBuilder(args)
            .UseConfiguration(new ConfigurationBuilder()
                .Build())
                .UseStartup<Startup>()
                .Build();


    }
}




//using System.Linq;
//using System.Threading.Tasks;
//using Microsoft.AspNetCore;
//using Microsoft.AspNetCore.Hosting;
//using Microsoft.Extensions.Configuration;
//using Microsoft.Extensions.Logging;

//namespace WeatherMicroservice
//{
//    public class Program
//    {
//        public static void Main(string[] args)
//        {
////                .UseUrls("http://*:1000")
//            var host = new WebHostBuilder()
//                .UseUrls(GetServerUrls(args))
//                .UseKestrel()
//                .UseContentRoot(Directory.GetCurrentDirectory())
//                .UseIISIntegration()
//                .UseStartup<Startup>()
//                .Build();

//            host.Run();
//        }
//        private static string[] GetServerUrls(string[] args)
//        {

//            List<string> urls = new List<string>();
//            for (int i = 0; i < args.Length; i++)
//            {
//                if ("--server.urls".Equals(args[i], StringComparison.OrdinalIgnoreCase))
//                {
//                    urls.Add(args[i + 1]);
//                }
//            }
//            return urls.ToArray();
//        }
//    }
//}

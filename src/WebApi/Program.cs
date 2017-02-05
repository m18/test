using System.IO;
using Microsoft.AspNetCore.Hosting;

namespace WebApi
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var host = new WebHostBuilder()
                .UseKestrel()
                // .UseUrls("http://*:5000", "http://*:5001", "http://*:5002")
                .UseContentRoot(Directory.GetCurrentDirectory())
                // .UseIISIntegration()
                .UseStartup<Startup>()
                .Build();

            host.Run();
        }
    }
}

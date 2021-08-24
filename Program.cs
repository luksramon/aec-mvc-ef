using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;

namespace aec_mvc_entity_framework
{
    public class Program
    {
        public static string ApiHost;
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}

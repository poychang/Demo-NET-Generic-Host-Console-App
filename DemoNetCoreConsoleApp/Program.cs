using DemoNetCoreConsoleApp.Models;
using DemoNetCoreConsoleApp.Services;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.IO;

namespace DemoNetCoreConsoleApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // 建立依賴注入的容器
            var serviceCollection = new ServiceCollection();
            ConfigureServices(serviceCollection);

            // 建立依賴服務提供者
            var serviceProvider = serviceCollection.BuildServiceProvider();

            // 透過依賴服務提供者來啟動主程式
            serviceProvider.GetService<App>().Run();
        }

        private static void ConfigureServices(IServiceCollection services)
        {
            var configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", false)
                .AddJsonFile($"appsettings.{Environment.GetEnvironmentVariable("NETCORE_ENVIRONMENT")}.json", optional: true)
                .AddEnvironmentVariables()
                .Build();

            services.AddOptions();
            services.Configure<AppSetting>(configuration);

            services.AddTransient<TimeService>();
            services.AddTransient<App>();
        }
    }
}

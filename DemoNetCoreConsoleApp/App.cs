using DemoNetCoreConsoleApp.Models;
using DemoNetCoreConsoleApp.Services;
using Microsoft.Extensions.Options;
using System;

namespace DemoNetCoreConsoleApp
{
    public class App
    {
        private readonly AppSetting _config;
        private readonly TimeService _service;

        public App(IOptions<AppSetting> config, TimeService service)
        {
            _config = config.Value;
            _service = service;
        }

        public void Run()
        {
            Console.WriteLine(_config.Title);

            _service.ShowCreateTime();
        }
    }
}

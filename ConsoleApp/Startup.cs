using Microsoft.Extensions.Hosting;

namespace ConsoleApp
{
    /// <summary>
    /// 泛型主機啟動的生命週期事件
    /// </summary>
    internal class Startup(IHostApplicationLifetime appLifetime, App app) : IHostedService
    {
        private readonly IHostApplicationLifetime _appLifetime = appLifetime;
        private readonly App _app = app;

        /// <summary>
        /// 啟動泛型主機，並註冊應用程式的生命週期事件
        /// </summary>
        /// <param name="cancellationToken">取消標誌</param>
        /// <returns>非同步啟動操作的任務</returns>
        public Task StartAsync(CancellationToken cancellationToken)
        {
            _appLifetime.ApplicationStarted.Register(_app.OnStarted);
            _appLifetime.ApplicationStopping.Register(_app.OnStopping);
            _appLifetime.ApplicationStopped.Register(_app.OnStopped);
            return Task.CompletedTask;
        }

        /// <summary>
        /// 停止泛型主機
        /// </summary>
        /// <param name="cancellationToken">取消標誌</param>
        /// <returns>非同步停止操作的任務</returns>
        public Task StopAsync(CancellationToken cancellationToken)
        {
            return Task.CompletedTask;
        }
    }
}

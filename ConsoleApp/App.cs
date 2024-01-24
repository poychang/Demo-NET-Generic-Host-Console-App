using Microsoft.Extensions.Logging;

namespace ConsoleApp
{
    /// <summary>
    /// 應用程式
    /// </summary>
    internal class App(ILogger<App> logger)
    {
        private readonly ILogger<App> _logger = logger;

        /// <summary>
        /// 當應用程式啟動時的動作
        /// </summary>
        public void OnStarted()
        {
            _logger.LogInformation("App OnStarted has been called.");
        }

        /// <summary>
        /// 當應用程式停止時的動作
        /// </summary>
        public void OnStopping()
        {
            _logger.LogInformation("App OnStopping has been called.");
        }

        /// <summary>
        /// 當應用程式關閉時的動作
        /// </summary>
        public void OnStopped()
        {
            _logger.LogInformation("App OnStopped has been called.");
        }
    }
}

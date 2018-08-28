using System;

namespace DemoNetCoreConsoleApp.Services
{
    public class TimeService
    {
        private readonly DateTime _createTime;

        public TimeService()
        {
            _createTime = DateTime.Now;
        }

        public void ShowCreateTime()
        {
            Console.WriteLine(_createTime);
        }
    }
}

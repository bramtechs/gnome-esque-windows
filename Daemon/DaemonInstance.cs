using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Daemon
{
    public class DaemonInstance
    {
        private List<ThreadedService> services;
        public DaemonInstance()
        {
            services = new List<ThreadedService>();
            services.Add(new HotCorner().Start());
            Console.WriteLine("Daemon started...");
        }

        public void WaitUntilFinished()
        {
            foreach (var service in services)
            {
                service.Join();
            }
        }
    }
}

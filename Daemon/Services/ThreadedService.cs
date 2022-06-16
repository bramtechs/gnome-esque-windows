using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Daemon
{
    public abstract class ThreadedService
    {
        protected Thread thread;
        protected bool shouldRun;
        public ThreadedService()
        {

        }

        public void Stop()
        {
            shouldRun = false;
            thread.Join();
        }

        public ThreadedService Start()
        {
            thread = new Thread(Process);
            thread.Start();
            shouldRun = true;
            return this;
        }

        public void Join()
        {
            if (thread != null)
            {
                thread.Join();
            }
            else
            {
                Console.WriteLine("Thread was not running.");
            }
        }

        public abstract void Process();
    }
}

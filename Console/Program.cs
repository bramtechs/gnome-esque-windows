using Daemon;
using System;
using System.Threading;

namespace Terminal
{
    public class Program
    {
        static void Main(string[] args)
        {
            DaemonInstance daemonInstance = new DaemonInstance();
            Console.WriteLine("Press Ctrl-C to stop.");
            daemonInstance.WaitUntilFinished();
        }
    }
}

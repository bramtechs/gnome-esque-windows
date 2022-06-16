using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Daemon
{
    public class HotCorner : ThreadedService
    {
        public Rectangle Region { get; set; }

        private const int COOLDOWN_TIME = 3;
        private int cooldown;

        public HotCorner()
        {
            Region = new Rectangle(0, 0, 3, 3);
        }

        public override void Process()
        {
            while (shouldRun)
            {
                Point mouse = MouseUtil.GetCursorPosition();
                if (Region.ContainsPoint(mouse))
                {
                    if (cooldown > COOLDOWN_TIME)
                    {
                        cooldown = 0;
                        KeyEmulator.ShowVirtualDesktop();
                    }
                }
                else
                {
                    cooldown++;
                }
                Thread.Sleep(100);
            }
        }
    }
}

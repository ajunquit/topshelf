using System;
using System.Collections.Generic;
using System.Text;
using System.Timers;

namespace topshelf_hello_world
{
    class HeartBeatService
    {
        readonly Timer _timer;
        public HeartBeatService()
        {
            _timer = new Timer(1000) { AutoReset = true };
            _timer.Elapsed += (sender, eventArgs) => Console.WriteLine("It is {0} and all is well", DateTime.Now);
        }
        public void Start() { _timer.Start(); }
        public void Stop() { _timer.Stop(); }
    }
}

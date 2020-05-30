using System;
using Topshelf;
using topshelf_hello_world;

namespace topshelf_hello_world
{
    class Program
    {
        static void Main(string[] args)
        {
            var rc = HostFactory.Run(x =>
            {
                x.Service<HeartBeatService>(s =>
                  {
                      s.ConstructUsing(name => new HeartBeatService());
                      s.WhenStarted(tc => tc.Start());
                      s.WhenStopped(tc => tc.Stop());
                  });
                x.RunAsLocalSystem();

                x.SetDescription("Sample Topshelf Host");
                x.SetDisplayName("ajunquit");
                x.SetServiceName("ajunquit");
            });

            var exitCode = (int)Convert.ChangeType(rc, rc.GetTypeCode());
            Environment.ExitCode = exitCode;
        }
    }
}

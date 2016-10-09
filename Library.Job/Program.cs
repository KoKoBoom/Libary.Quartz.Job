using System.IO;
using Topshelf;

namespace Library.Job
{
    class Program
    {
        static void Main(string[] args)
        {
            Directory.SetCurrentDirectory(System.AppDomain.CurrentDomain.BaseDirectory);

            HostFactory.Run(x =>
            {
                x.RunAsLocalSystem();
                //服务的描述
                x.SetDescription(Configuration.ServiceDescription);
                //服务的显示名称
                x.SetDisplayName(Configuration.ServiceDisplayName);
                //服务名称
                x.SetServiceName(Configuration.ServiceName);

                x.Service(factory =>
                {
                    QuartzServer server = new QuartzServer();
                    server.Initialize();
                    return server;
                });
            });

        }
    }
}
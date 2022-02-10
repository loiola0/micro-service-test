using Topshelf;

namespace TestTopShelf
{
    public class ConfigureService
    {
        internal static void Configure(){
        HostFactory.Run(configure =>
            {
                configure.Service<MyServiceWS>(service =>
                {
                    service.ConstructUsing(s => new MyServiceWS());
                    service.WhenStarted(s => s.Start());
                    service.WhenStopped(s => s.Stop());
                });
                //Configure a Conta que o serviço do Windows usa para rodar
                configure.RunAsLocalSystem();
                configure.SetServiceName("MeuServicoWindowsComTopshelf");
                configure.SetDisplayName("MeuServicoWindowsComTopshelf");
                configure.SetDescription("Meu serviço Windows com Topshelf");
            });
        }
    }
}
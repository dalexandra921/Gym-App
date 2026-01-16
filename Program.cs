using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Windows.Forms;

namespace GymApp_final
{
    internal static class Program
    {
        public static IHost AppHost { get; private set; } = null!; //variabila globalã pentru host

        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();

            AppHost = Host.CreateDefaultBuilder() //container central de DI
                .ConfigureServices((context, services) =>
                {
                    services.AddLogging(b => b.AddConsole()); //pt logging în consolã

                    services.AddTransient<LoginForm>(); //înregistreazã form-urile în DI si login ul nou
                    services.AddTransient<AdminForm>();
                })
                .Build();//construie?te host-ul

            // porneste aplicatia cu form-ul luat din DI
            var login = AppHost.Services.GetRequiredService<LoginForm>();
            Application.Run(login);

        }
    }
}
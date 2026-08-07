using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Oil_level_glass.UI;
using Oil_level_glass.UI.Abstractions;
using Oil_level_glass.UI.Abstractions.Wizards.Wizard3d;
using Oil_level_glass.UI.Main;
using Oil_level_glass.UI.Wizard3d;

namespace App
{
    internal static class Program
    {
        private static readonly IHost _appHost;

        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(_appHost.Services.GetRequiredService<IMain>() as Form);
        }

        static Program()
        {
            _appHost = Host.CreateDefaultBuilder()
                .ConfigureServices( (hostContext, services) => 
                {
                    services.AddForms();

                }).Build();
        }
    }
}
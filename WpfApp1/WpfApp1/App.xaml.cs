using Autofac;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls.Primitives;

namespace WpfApp1
{
    /// <summary>
    /// Logika interakcji dla klasy App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);

            var builder = new ContainerBuilder();
            builder.RegisterType<MainWindow>().AsSelf();
            builder.RegisterType<LabelGenerator>().As<IControlGenerator>();
            builder.RegisterType<PanelFiller>().AsImplementedInterfaces();

            var container = builder.Build();
            using (var scope=container.BeginLifetimeScope()) //scope = kontekst,wspóle dla aplikacji w trakcie działania 
            {
                var window = scope.Resolve<MainWindow>();
                window.Show();
            }
        }
    }
}

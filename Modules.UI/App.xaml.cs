using System;
using System.Windows;

namespace Modules.UI
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            //base.OnStartup(e);
            try
            {
                AppDomain currentDomain = AppDomain.CurrentDomain;
                currentDomain.UnhandledException += new UnhandledExceptionEventHandler(AppDomainUnhandledException);

                base.OnStartup(e);
                var bs = new Bootstrapper();
                bs.Run();
            }
            catch (Exception ex)
            {
                HandleException(ex);
            }
        }

        private static void AppDomainUnhandledException(object sender, UnhandledExceptionEventArgs e)
        {
            HandleException(e.ExceptionObject as Exception);
        }

        private static void HandleException(Exception ex)
        {
            if (ex == null)
                return;

            MessageBox.Show(
                ex.Message,
                "Location Management",
                MessageBoxButton.OK,
                MessageBoxImage.Error
                );

            Environment.Exit(1);
        }
    }
}

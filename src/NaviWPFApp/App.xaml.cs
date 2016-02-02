using NaviWPFApp.Domain;

namespace NaviWPFApp
{
    using System.Windows;
    using NaviWPFApp.Views;

    public partial class App : Application
    {
        public static NavigationService Navigation;

        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);

            BusinessLogic businessLogic = new BusinessLogic();

            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();

            Navigation = new NavigationService(mainWindow.MyFrame);
            Navigation.Navigate<FirstPage>();
        }
    }
}

using NaviWPFApp.ViewModels.Common;

namespace NaviWPFApp.ViewModels.Pages
{
    public class SecondPageViewModel : MyObservableObject
    {
        private readonly INavigationService navigationService;

        public SecondPageViewModel(INavigationService navigationService)
        {
            this.navigationService = navigationService;
        }

        public MyCommand Go1
        {
            get { return new MyCommand(x => navigationService.Navigate("FirstPage")); }
        }
    }
}

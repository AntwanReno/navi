using NaviWPFApp.Domain;
using NaviWPFApp.ViewModels.Common;

namespace NaviWPFApp.ViewModels
{
    public class SecondPageViewModel : MyObservableObject
    {
        private readonly INavigationService navigationService;
        private readonly BusinessLogic businessLogic;

        public SecondPageViewModel(INavigationService navigationService, BusinessLogic businessLogic = null)
        {
            this.navigationService = navigationService;
            this.businessLogic = businessLogic;
        }

        public MyCommand BackToFirstPageCommand
        {
            get { return new MyCommand(x => navigationService.Navigate("FirstPage")); }
        }

        public MyCommand CountSomethingCommand
        {
            get { return new MyCommand(x => businessLogic?.CountSomething()); }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NaviWPFApp.ViewModels.Common;

namespace NaviWPFApp.ViewModels
{
    public class FirstPageViewModel : MyObservableObject
    {
        private readonly INavigationService navigationService;
        
        public FirstPageViewModel(INavigationService navigationService)
        {
            this.navigationService = navigationService;
        }
        
        public MyCommand GoToSecondPageCommand
        {
            get { return new MyCommand(x => navigationService.Navigate("SecondPage")); }
        }
    }
}

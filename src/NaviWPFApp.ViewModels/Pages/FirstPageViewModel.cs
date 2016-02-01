using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NaviWPFApp.ViewModels.Common;

namespace NaviWPFApp.ViewModels.Pages
{
    public class FirstPageViewModel : MyObservableObject
    {
        private readonly INavigationService navigationService;
        
        public FirstPageViewModel(INavigationService navigationService)
        {
            this.navigationService = navigationService;
        }
        
        public MyCommand Go2
        {
            get { return new MyCommand(x => navigationService.Navigate("SecondPage")); }
        }
    }
}

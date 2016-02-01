using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using NaviWPFApp.ViewModels.Common;

namespace NaviWPFApp.ViewModels.UserControls
{
    public class FooUserControlViewModel : MyObservableObject
    {
        private string helloText;
        public string HelloText
        {
            get { return helloText; }
            set { Set(ref helloText, value); }
        }

        private string myTextBox;
        public string MyTextBox
        {
            get { return myTextBox; }
            set { Set(ref myTextBox, value); }
        }

        public ICommand SayHalloCommand { get; set; }

        public FooUserControlViewModel()
        {
            HelloText = "Dupa!";
            SayHalloCommand = new MyCommand(p => HelloText = "It works!");
            //SayHalloCommand = new RelayCommand(() => HelloText = "It works!" + MyTextBox + "!!");
        }
    }
}
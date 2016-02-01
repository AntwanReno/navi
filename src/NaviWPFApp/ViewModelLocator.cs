namespace NaviWPFApp
{
    using NaviWPFApp.ViewModels.Pages;

    public class ViewModelLocator
    {
        public FirstPageViewModel FirstPageViewModel => new FirstPageViewModel(App.Navigation);
        public SecondPageViewModel SecondPageViewModel => new SecondPageViewModel(App.Navigation);
    }
}

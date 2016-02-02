namespace NaviWPFApp
{
    using ViewModels;

    public class ViewModelLocator
    {
        public FirstPageViewModel FirstPageViewModel => new FirstPageViewModel(App.Navigation);
        public SecondPageViewModel SecondPageViewModel => new SecondPageViewModel(App.Navigation);
    }
}

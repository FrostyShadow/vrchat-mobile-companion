namespace VrChatCompanion.ViewModels
{
    public class HomeViewModel : BaseViewModel
    {
        private string _text;

        public string Text
        {
            get => _text;
            set => SetProperty(ref _text, value);
        }

        public HomeViewModel()
        {
            Title = "Home";
            Text = "Hello World!";
        }
    }
}
using System.Threading.Tasks;
using io.github.vrchatapi.Api;
using Xamarin.Forms;

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

        private ImageSource _userIcon;

        public ImageSource UserIcon
        {
            get => _userIcon;
            set => SetProperty(ref _userIcon, value);
        }

        public HomeViewModel()
        {
            Title = "Home";

            Init();
        }

        private async void Init()
        {
            var user = await App.AuthApi.GetCurrentUserAsync();

            Text = $"Hello {user.DisplayName}!";
            UserIcon = user.UserIcon;
        }
    }
}
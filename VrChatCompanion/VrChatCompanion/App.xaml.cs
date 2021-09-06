using io.github.vrchatapi.Api;
using Xamarin.Forms;

namespace VrChatCompanion
{
    public partial class App : Application
    {
        public static AuthenticationApi AuthApi { get; set; }

        public App()
        {
            InitializeComponent();
            
            MainPage = new AppShell();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
using Xamarin.Forms;
using VRChatAPI;

namespace VrChatCompanion
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            DependencyService.Register<VRChatAPIClient>();
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
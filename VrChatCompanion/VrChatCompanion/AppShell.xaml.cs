using System;
using System.Diagnostics;
using VrChatCompanion.Views;
using Xamarin.Forms;

namespace VrChatCompanion
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();
            //Routing.RegisterRoute(nameof(ItemDetailPage), typeof(ItemDetailPage));
            //Routing.RegisterRoute(nameof(NewItemPage), typeof(NewItemPage));
        }

        private async void OnMenuItemClicked(object sender, EventArgs e)
        {
            var logout = await App.AuthApi.LogoutAsync();
            Debug.Print(logout.ToJson());
            await Current.GoToAsync("//LoginPage");
        }
    }
}
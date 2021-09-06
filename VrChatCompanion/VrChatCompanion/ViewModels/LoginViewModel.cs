using System;
using System.Diagnostics;
using Newtonsoft.Json;
using VrChatCompanion.Views;
using Xamarin.Forms;
using io.github.vrchatapi.Api;
using io.github.vrchatapi.Client;
using VrChatCompanion.Models;

namespace VrChatCompanion.ViewModels
{
    public class LoginViewModel : BaseViewModel
    {

        public LoginViewModel()
        {
            LoginCommand = new Command(OnLoginClicked);
            
        }

        public Command LoginCommand { get; }

        private string _username;

        public string Username
        {
            get => _username;
            set => SetProperty(ref _username, value);
        }

        private string _password;

        public string Password
        {
            get => _password; 
            set => SetProperty(ref _password, value);
        }

        private bool _isErrorVisible;

        public bool IsErrorVisible
        {
            get => _isErrorVisible;
            set => SetProperty(ref _isErrorVisible, value);
        }

        private string _errorMessage;

        public string ErrorMessage
        {
            get => _errorMessage;
            set => SetProperty(ref _errorMessage, value);
        }

        private async void OnLoginClicked(object obj)
        {
            // Prefixing with `//` switches to a different navigation stack instead of pushing to the active one
            Configuration.Default.Username = Username;
            Configuration.Default.Password = Password;

            try
            {
                App.AuthApi = new AuthenticationApi();
                var user = await App.AuthApi.GetCurrentUserAsync();
                Console.WriteLine($"Logged in as: {user.DisplayName}");
                await Shell.Current.GoToAsync($"//{nameof(HomePage)}", true);
            }
            catch (ApiException ex)
            {
                Debug.Print(ex.Message);
                Debug.Print(ex.StackTrace);
                IsErrorVisible = true;
                ErrorMessage = JsonConvert.DeserializeObject<ApiErrorMessage>(ex.Message.Substring(ex.Message.IndexOf(':') + 1)).Error.Message;
            }

        }
    }
}
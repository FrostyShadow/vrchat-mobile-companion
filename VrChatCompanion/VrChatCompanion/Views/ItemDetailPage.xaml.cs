using System.ComponentModel;
using Xamarin.Forms;
using VrChatCompanion.ViewModels;

namespace VrChatCompanion.Views
{
    public partial class ItemDetailPage : ContentPage
    {
        public ItemDetailPage()
        {
            InitializeComponent();
            BindingContext = new ItemDetailViewModel();
        }
    }
}
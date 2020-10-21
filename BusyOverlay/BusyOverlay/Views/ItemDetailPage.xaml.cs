using System.ComponentModel;
using Xamarin.Forms;
using BusyOverlay.ViewModels;

namespace BusyOverlay.Views
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
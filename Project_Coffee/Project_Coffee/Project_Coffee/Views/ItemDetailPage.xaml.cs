using Project_Coffee.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace Project_Coffee.Views
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
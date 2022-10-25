using Project_Coffee.ViewModels;
using Project_Coffee.Views;
using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace Project_Coffee
{
    public partial class AppShell : Xamarin.Forms.Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute(nameof(ItemDetailPage), typeof(ItemDetailPage));
            Routing.RegisterRoute(nameof(NewItemPage), typeof(NewItemPage));
        }

    }
}

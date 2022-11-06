using KaffeeApp.MenuPages.DataModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace KaffeeApp.MenuPages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class QuickBitesPage : ContentPage
    {
        public QuickBitesPage()
        {
            InitializeComponent();
            List<MenuItems> Blist = new List<MenuItems>
            {
                new MenuItems{Name="Bagel               $1.50", ImageUrl="Bagel", Price="Freshly Baked Each Morning."},
                new MenuItems{Name="Eggs Benedict      $6.50", ImageUrl="Eggs", Price="Poached Eggs over Bacon and buttered toasted English Muffin, topped with Hollandaise sauce."},
            };
            BitesList.ItemsSource = Blist;
        }
    }
}
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
    public partial class HotDrinksPage : ContentPage
    {
        public HotDrinksPage()
        {
            InitializeComponent();
            List<MenuItems> Hlist = new List<MenuItems>
            {
                new MenuItems{Name="Blonde Cafe Latte", ImageUrl="https://images.squarespace-cdn.com/content/v1/5a7cbe247131a5f17b3cc8fc/1519447742018-MOHBW2G0VOQ7QSCPJE14/Americano-Coffee-Lounge-Ingredients.jpg", Price="$3.75"},
                new MenuItems{Name="Caramel Macchiatto", ImageUrl="https://www.allrecipes.com/thmb/Wh0Qnynwdxok4oN0NZ1Lz-wl0A8=/1500x0/filters:no_upscale():max_bytes(150000):strip_icc()/9428203-9d140a4ed1424824a7ddd358e6161473.jpg", Price="$4.25"},
                new MenuItems{Name="Skinny Mocha", ImageUrl="https://qph.cf2.quoracdn.net/main-qimg-c630b9599e4522019f50dae9dcb4407d-pjlq", Price = "$4.00"},
                new MenuItems{Name="Hot Coffee", ImageUrl="https://krave.com.bd/wp-content/uploads/2020/06/Espresso-Single.jpg", Price = "$3.25"},
                new MenuItems{Name="Irish Coffee", ImageUrl="https://www.acouplecooks.com/wp-content/uploads/2020/10/how-to-make-a-macchiato-003s.jpg", Price = "$4.25"},

            };
            HotList.ItemsSource = Hlist;
        }
    }
}
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
    public partial class ColdDrinksPage : ContentPage
    {
        public ColdDrinksPage()
        {
            InitializeComponent();
            List<MenuItems> Clist = new List<MenuItems>
            {
                new MenuItems{Name="Nitro Cold Brew", ImageUrl="https://images.squarespace-cdn.com/content/v1/5a7cbe247131a5f17b3cc8fc/1519447742018-MOHBW2G0VOQ7QSCPJE14/Americano-Coffee-Lounge-Ingredients.jpg", Price="$3.75"},
                new MenuItems{Name="Iced Latte", ImageUrl="https://www.allrecipes.com/thmb/Wh0Qnynwdxok4oN0NZ1Lz-wl0A8=/1500x0/filters:no_upscale():max_bytes(150000):strip_icc()/9428203-9d140a4ed1424824a7ddd358e6161473.jpg", Price="$4.25"},
                new MenuItems{Name="Frappuccino", ImageUrl="https://qph.cf2.quoracdn.net/main-qimg-c630b9599e4522019f50dae9dcb4407d-pjlq", Price = "$4.50"},
                new MenuItems{Name="Iced Coffee", ImageUrl="https://krave.com.bd/wp-content/uploads/2020/06/Espresso-Single.jpg", Price = "$3.00"},
                new MenuItems{Name="Creamy Iced Coffee", ImageUrl="https://www.acouplecooks.com/wp-content/uploads/2020/10/how-to-make-a-macchiato-003s.jpg", Price = "$3.50"},
            };
            ColdList.ItemsSource = Clist;
        }
    }
}
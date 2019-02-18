using iDent.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace iDent.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MenuPage : ContentPage
    {
        MainPage RootPage { get => Application.Current.MainPage as MainPage; }
        List<HomeMenuItem> menuItems;
        List<HomeMenuItem> menuFooterItems;
        
        public MenuPage()
        {
            InitializeComponent();

            menuItems = new List<HomeMenuItem>
            {
                new HomeMenuItem {Id = MenuItemType.Browse, Title="*Test Screen*" },
                new HomeMenuItem {Id = MenuItemType.Browse, Title="Home" },
                new HomeMenuItem {Id = MenuItemType.Apply, Title="Apply" },
                new HomeMenuItem {Id = MenuItemType.StudentLinks, Title="Student Links"},
                new HomeMenuItem {Id = MenuItemType.MeetTheStaff, Title="Meet the Staff" },
                new HomeMenuItem {Id = MenuItemType.Gallery, Title="Gallery" },
                new HomeMenuItem {Id = MenuItemType.StudentLinks, Title="Testimonials" },
                new HomeMenuItem {Id = MenuItemType.ContactUs, Title="Contact Us" },
                new HomeMenuItem {Id = MenuItemType.About, Title="About Us" }
            };

            menuFooterItems = new List<HomeMenuItem>
            {
                new HomeMenuItem {Id = MenuItemType.Facebook, Title = "Facebook"},
                new HomeMenuItem {Id = MenuItemType.Twitter, Title = "Twitter"},

            };

            ListViewMenu.ItemsSource = menuItems;
            ListViewMenu.SelectedItem = menuItems[0];
            ListViewMenu.ItemSelected += async (sender, e) =>
            {
                if (e.SelectedItem == null)
                    return;

                var id = (int)((HomeMenuItem)e.SelectedItem).Id;
                await RootPage.NavigateFromMenu(id);
            };

            ListViewMenuFooter.ItemsSource = menuFooterItems;
            ListViewMenuFooter.ItemSelected += (sender, e) =>
            {
                var id = (int)((HomeMenuItem)e.SelectedItem).Id;
                switch (id)
                {
                    case (int)MenuItemType.Facebook:
                        OpenLink(new Uri("https://www.facebook.com/"));
                        break;
                    case (int)MenuItemType.Twitter:
                        OpenLink(new Uri("https://www.twitter.com/"));

                        break;
                   
                }
            };


        }

        private void OpenLink(Uri uri)
        {
             Device.OpenUri(uri);
        }
    }
}
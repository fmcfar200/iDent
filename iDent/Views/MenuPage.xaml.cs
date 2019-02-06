using iDent.Models;
using System;
using System.Collections.Generic;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace iDent.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MenuPage : ContentPage
    {
        MainPage RootPage { get => Application.Current.MainPage as MainPage; }
        List<HomeMenuItem> menuItems;
        public MenuPage()
        {
            InitializeComponent();

            menuItems = new List<HomeMenuItem>
            {
                new HomeMenuItem {Id = MenuItemType.Browse, Title="*Test Screen*" },
                new HomeMenuItem {Id = MenuItemType.Browse, Title="Home" },
                new HomeMenuItem {Id = MenuItemType.Apply, Title="Apply" },
                new HomeMenuItem {Id = MenuItemType.UsefulLinks, Title="Useful Links"},
                new HomeMenuItem {Id = MenuItemType.MeetTheStaff, Title="Meet the Staff" },
                new HomeMenuItem {Id = MenuItemType.Gallery, Title="Gallery" },
                new HomeMenuItem {Id = MenuItemType.UsefulLinks, Title="Testimonials" },
                new HomeMenuItem {Id = MenuItemType.ContactUs, Title="Contact Us" },
                new HomeMenuItem {Id = MenuItemType.About, Title="About" }
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
        }
    }
}
using iDent.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace iDent.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MainPage : MasterDetailPage
    {
        Dictionary<int, NavigationPage> MenuPages = new Dictionary<int, NavigationPage>();
        public MainPage()
        {
            InitializeComponent();

            MasterBehavior = MasterBehavior.Popover;

            MenuPages.Add((int)MenuItemType.About, (NavigationPage)Detail);
        }

        public async Task NavigateFromMenu(int id)
        {
            if (!MenuPages.ContainsKey(id))
            {
                switch (id)
                {
                    case (int)MenuItemType.About:
                        MenuPages.Add(id, new NavigationPage(new AboutPage()));
                        break;
                    case (int)MenuItemType.MeetTheStaff:
                        MenuPages.Add(id, new NavigationPage(new TeamPage()));
                        break;
                    case (int)MenuItemType.ContactUs:
                        MenuPages.Add(id, new NavigationPage(new ContactPage()));
                        break;
                    case (int)MenuItemType.Gallery:
                        MenuPages.Add(id, new NavigationPage(new GalleryPage()));
                        break;
                    case (int)MenuItemType.Apply:
                        MenuPages.Add(id, new NavigationPage(new ApplyPage()));
                        break;
                    case (int)MenuItemType.StudentLinks:
                        MenuPages.Add(id, new NavigationPage(new StudentLinksPage()));
                        break;

                }
            }

            var newPage = MenuPages[id];

            if (newPage != null && Detail != newPage)
            {
                Detail = newPage;

                if (Device.RuntimePlatform == Device.Android)
                    await Task.Delay(100);

                IsPresented = false;
            }
        }
    }
}
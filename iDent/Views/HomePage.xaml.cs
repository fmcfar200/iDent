using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using System.Net.Http;
using System.Diagnostics;
using Newtonsoft.Json;
using iDent.Models;

namespace iDent.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class HomePage : ContentPage
	{
        HttpClient httpClient = new HttpClient();
        RootObject newsObject = new RootObject();
        public HomePage()
        {
            InitializeComponent();
            RefreshDataAsync();
           
        }

        public async void RefreshDataAsync()
        {
            activityIndicator.IsRunning = true;
            activityIndicator.IsVisible = true;
            // RestUrl = https://developer.xamarin.com:8081/api/todoitems/
            var uri = new Uri(string.Format("https://www.googleapis.com/blogger/v3/blogs/5130824177252453241/posts?key=AIzaSyC6PBj2-KYBm_mJ64Df8zstR_ZfnbCvwt0"));

            var response = await httpClient.GetAsync(uri);
            if (response.IsSuccessStatusCode)
            {
                var content = await response.Content.ReadAsStringAsync();
                newsObject = JsonConvert.DeserializeObject<RootObject>(content);

                Debug.WriteLine(newsObject.items[0].title);
                NewsListView.ItemsSource = newsObject.items.Take(2);
                activityIndicator.IsRunning = false;
                activityIndicator.IsVisible = false;

            }
           
            
        }
    }


}
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
using HtmlAgilityPack;

namespace iDent.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class HomePage : ContentPage
	{
        HttpClient httpClient = new HttpClient();
        RootObject newsObject = new RootObject();
        List<Item> newsItemSource = new List<Item>();

        public HomePage()
        {
            InitializeComponent();
            RefreshDataAsync();
           
        }

        public async void RefreshDataAsync()
        {
            ActivityIndicatorActive(true);
            // RestUrl = https://developer.xamarin.com:8081/api/todoitems/
            var uri = new Uri(string.Format("https://www.googleapis.com/blogger/v3/blogs/5130824177252453241/posts?key=AIzaSyC6PBj2-KYBm_mJ64Df8zstR_ZfnbCvwt0"));

            var response = await httpClient.GetAsync(uri);
            if (response.IsSuccessStatusCode)
            {
                var content = await response.Content.ReadAsStringAsync();


                
                
                newsObject = JsonConvert.DeserializeObject<RootObject>(content);

                if (newsObject != null && newsObject.items != null)
                {
                    foreach (Item item in newsObject.items)
                    {
                        string itemContent = item.content;

                        if (!string.IsNullOrEmpty(itemContent) && !string.IsNullOrWhiteSpace(itemContent))
                        {
                            
                            int firstImageLink = itemContent.IndexOf("src=\"") + "src=\"".Length;
                            int lastImageLink = itemContent.LastIndexOf("\" w");
                            string imageLink = itemContent.Substring(firstImageLink, lastImageLink - firstImageLink);
                            item.headerImageURL = imageLink;

                            int firstBody = itemContent.LastIndexOf("</div>\n") + "</div>\n".Length;
                            int lastBody= itemContent.LastIndexOf("");
                            string body = itemContent.Substring(firstBody);
                            item.body = body;

                        }


                    }

                    NewsListView.ItemsSource = newsObject.items.Take(2);
                    ActivityIndicatorActive(false);
                }
                else
                {
                    Debug.WriteLine("No Recent News");
                    ActivityIndicatorActive(false);
                    NoNewsLabel.Text = "No Recent News";
                    NoNewsLabel.IsVisible = true;

                }

                
            }
            else
            {
                Debug.WriteLine("No Connection");
                ActivityIndicatorActive(false);
                NoNewsLabel.Text="No Connection Available";
                NoNewsLabel.IsVisible = true;
            }


        }

        private void ActivityIndicatorActive(bool onOffBool)
        {
            activityIndicator.IsRunning = onOffBool;
            activityIndicator.IsVisible = onOffBool;
        }
    }


}
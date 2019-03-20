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
        List<Item> newsItemSource = new List<Item>();

        public HomePage()
        {
            InitializeComponent();
            RefreshDataAsync();
           
        }

        public async void RefreshDataAsync()
        {
            ActivityIndicator(true);
            // RestUrl = https://developer.xamarin.com:8081/api/todoitems/
            var uri = new Uri(string.Format("https://www.googleapis.com/blogger/v3/blogs/5130824177252453241/posts?key=AIzaSyC6PBj2-KYBm_mJ64Df8zstR_ZfnbCvwt0"));

            var response = await httpClient.GetAsync(uri);
            if (response.IsSuccessStatusCode)
            {
                var content = await response.Content.ReadAsStringAsync();


                try
                {
                    newsObject = JsonConvert.DeserializeObject<RootObject>(content);

                    if (newsObject != null)
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
                                //int lastBody= itemContent.LastIndexOf("");
                                string body = itemContent.Substring(firstBody);
                                item.body = body + " " + item.headerImageURL;

                            }


                        }
                    }

                }
                catch (NullReferenceException e)
                {
                    ActivityIndicator(false);
                    throw new System.NullReferenceException();
                }


                


                NewsListView.ItemsSource = newsObject.items.Take(2);
                ActivityIndicator(false);

            }


        }

        private void ActivityIndicator(bool onOffBool)
        {
            activityIndicator.IsRunning = onOffBool;
            activityIndicator.IsVisible = onOffBool;
        }
    }


}
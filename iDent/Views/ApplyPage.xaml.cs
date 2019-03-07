using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace iDent.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ApplyPage : ContentPage
	{
		public ApplyPage ()
		{
			InitializeComponent ();
		}

      

        async void OnCallJavaScriptButtonClicked(object sender, EventArgs e)
        {
           
            await _webView.EvaluateJavaScriptAsync($"document.getElementById('textfield_1').value = {10}; document.getElementsByName('savevalues')[0].click()");

        }

        async void webviewNavigated(object sender, WebNavigatingEventArgs e)
        {
            string result = await _webView.EvaluateJavaScriptAsync("document.getElementById('yui_3_17_2_1_1551722973698_37').innerHTML");
            await DisplayAlert("Navigated", result, "OK");
        }

        //string result = await _webView.EvaluateJavaScriptAsync("document.getElementsByName('savevalues')[0].click()");

    }
}

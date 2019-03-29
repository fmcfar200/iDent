using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Timers;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using iDent.Models;
using System.Web;
using System.Threading;

namespace iDent.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ContactComplete : ContentPage
	{
        ContactForm contactForm = new ContactForm();
        private string applyValuesJS;
        private string submitValuesJS;

        private string valueCheck = "";

        public ContactComplete (ContactForm form)
		{
			InitializeComponent ();
            ActivityIndicatorActive(true);
            contactForm = form;

            applyValuesJS = "javascript:" + $"document.getElementById('textfield_1').value = '{HttpUtility.JavaScriptStringEncode(contactForm.Name)}';" +
            $"document.getElementById('textfield_2').value = '{HttpUtility.JavaScriptStringEncode(contactForm.Email)}';" +
            $"document.getElementById('textarea_3').value = '{HttpUtility.JavaScriptStringEncode(contactForm.Message)}';" +
            $"document.getElementById('textfield_5').value = '{HttpUtility.JavaScriptStringEncode(contactForm.DateOfMessage)}'";

            submitValuesJS = "javascript:" + $"document.getElementsByName('savevalues')[0].click();";



        }

        private async void TheWebView_Navigated(object sender, WebNavigatedEventArgs e)
        {
            await theWebView.EvaluateJavaScriptAsync(applyValuesJS);
            int sleepCount = 0;
            bool passed = false;

            do
            {
              
                valueCheck = await theWebView.EvaluateJavaScriptAsync("javascript:document.getElementById('textfield_1').value");
                if (passed == true)
                {
                    Thread.Sleep(5000);
                    sleepCount += 1;
                }

                passed = true;
                
            }
            while (String.IsNullOrWhiteSpace(valueCheck) && sleepCount <=0);

            if (!String.IsNullOrWhiteSpace(valueCheck))
            {
                Debug.WriteLine("JavaScript Value Is Not Null or White Space: " + valueCheck);
                //await theWebView.EvaluateJavaScriptAsync(submitValuesJS);
                Thread.Sleep(1000);
                ActivityIndicatorActive(false);
                Complete_Layout.IsVisible = true;
                return;

            }
            else
            {
                ActivityIndicatorActive(false);
                Failed_Layout.IsVisible = true;
            }

        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            theWebView.IsVisible = true;
        }

        private void ActivityIndicatorActive(bool onOffBool)
        {
            activityIndicator.IsRunning = onOffBool;
            activityIndicator.IsVisible = onOffBool;
        }

        protected override bool OnBackButtonPressed()
        {
            Navigation.PopToRootAsync();
            return base.OnBackButtonPressed();
        }
    }
}
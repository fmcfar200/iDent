using Plugin.Messaging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using iDent.Models;
using System.Web;

namespace iDent.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ContactPage : ContentPage
    {
        private ContactForm contactForm = new ContactForm();
        string applyValuesJS;
        string submitValuesJS;
        
        public ContactPage()
        {
            InitializeComponent();
            applyValuesJS = "javascript:" + $"document.getElementById('textfield_1').value = '{HttpUtility.JavaScriptStringEncode(contactForm.Name)}';" +
            $"document.getElementById('textfield_2').value = '{HttpUtility.JavaScriptStringEncode(contactForm.Email)}';" +
            $"document.getElementById('textarea_3').value = '{HttpUtility.JavaScriptStringEncode(contactForm.Message)}';" +
            $"document.getElementById('textfield_5').value = '{HttpUtility.JavaScriptStringEncode(contactForm.DateOfMessage)}'";


            submitValuesJS = "javascript:" + $"document.getElementsByName('savevalues')[0].click();";

           

        }

        private async void Send_Button_Clicked(object sender, EventArgs e)
        {
            bool allValid = NameEntryBehavior.isValid && EmailValidation.isValid && MessageBehaviour.isValid;
            
            if (allValid)
            {
                contactForm.Name = NameEntry.Text;
                contactForm.Email = EmailEntry.Text;
                contactForm.Message = MessageEntry.Text;

                await theWebView.EvaluateJavaScriptAsync(applyValuesJS);

                await Navigation.PushAsync(new ContactComplete(contactForm));

            }
            else
            {
                await DisplayAlert("Not All Fields are Valid", "Please ensure all information is correct", "Close");
                return;
            }
        }

        
    }
} 

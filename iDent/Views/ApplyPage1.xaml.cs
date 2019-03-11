using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using iDent.Models;
using iDent.ViewModels;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using System.Text.RegularExpressions;

namespace iDent.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ApplyPage1 : ContentPage
    {
        ApplicationForm applicationForm = new ApplicationForm();

        public ApplyPage1()
        {
            InitializeComponent();

        }

        async void OnNextPageButtonClicked(object sender, EventArgs e)
        { 
            int i = CoursePicker.SelectedIndex + 1;
            applicationForm.CourseNumber = i;
            await Navigation.PushAsync(new ApplyPage2(applicationForm));
           
            
        }


        //async void OnCallJavaScriptButtonClicked(object sender, EventArgs e)
        //{
        //    //document.getElementsByName('savevalues')[0].click() saves and uploads values
        //    await _webView.EvaluateJavaScriptAsync($"document.getElementById('textfield_1').value = {10};");

        //}

        //async void webviewNavigated(object sender, WebNavigatingEventArgs e)
        //{
        //    string result = await _webView.EvaluateJavaScriptAsync("document.getElementById('yui_3_17_2_1_1551722973698_37').innerHTML");
        //    await DisplayAlert("Navigated", result, "OK");
        //}

        //string result = await _webView.EvaluateJavaScriptAsync("document.getElementsByName('savevalues')[0].click()");


    }
    
}

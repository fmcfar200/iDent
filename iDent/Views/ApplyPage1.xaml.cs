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
        public ApplicationForm applicationForm = new ApplicationForm();

        public ApplyPage1()
        {
            InitializeComponent();
           
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            System.Diagnostics.Debug.WriteLine(applicationForm.SchoolCollege);

        }

        async void OnNextPageButtonClicked(object sender, EventArgs e)
        {
            bool allValid = CoursePicker.SelectedItem != null && NameEntryBehaviour.isValid && EmailValidation.isValid && houseNumberBehavior.isValid &&
                streetNameBehavior.isValid && townNameBehavior.isValid && countyNameBehavior.isValid &&
                postcodeBehavior.isValid;

            if (allValid)
            {
                string streetNumberAndName = HouseNumberEntry.Text + " " + StreetEntry.Text;
                string town = TownEntry.Text;
                string county = CountyEntry.Text;
                string country = CountryEntry.Text;
                string postcode = PostcodeEntry.Text;
                string fullAddress = streetNumberAndName + "\n" + town + "\n" + county + "\n" + country + "\n" + postcode;

                applicationForm.CourseNumber = CoursePicker.SelectedIndex + 1;
                applicationForm.DateOfApplication = DateTime.Now.Day.ToString() + "/" + DateTime.Now.Month.ToString() + "/" + DateTime.Now.Year.ToString();
                applicationForm.Name = NameEntry.Text;
                applicationForm.Address = fullAddress;
                applicationForm.DOB = DOBPicker.Date.Day + "/" + DOBPicker.Date.Month + "/" + DOBPicker.Date.Year;
                applicationForm.email = EmailEntry.Text;
                applicationForm.HomeNumber = HomeTelEntry.Text;
                applicationForm.MobileNumber = MobileTelEntry.Text;



                //System.Diagnostics.Debug.WriteLine(
                //    applicationForm.CourseNumber + "\n" + 
                //    applicationForm.DateOfApplication + "\n" +
                //    applicationForm.Name + "\n" + "\n" +
                //    applicationForm.Address + "\n" + "\n" +
                //    applicationForm.DOB + "\n" +
                //    applicationForm.email + "\n" +
                //    applicationForm.HomeNumber+ "\n" +
                //    applicationForm.MobileNumber
                //    );

                await Navigation.PushAsync(new ApplyPage2(applicationForm));


            }
            else
            {
                await DisplayAlert("Not All Fields are Valid", "Please ensure all information is correct", "Close");
                return;
            }
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

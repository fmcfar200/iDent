using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;


using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using iDent.Models;
using iDent.ViewModels;

namespace iDent.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ApplyPageReview : ContentPage
	{
        ApplyPage1ViewModel applyPage1ViewModel = new ApplyPage1ViewModel();
        ApplicationForm applicationForm = new ApplicationForm();
        string applyValuesJS;
        string submitValuesJS;

		public ApplyPageReview (ApplicationForm applyForm)
		{
			InitializeComponent ();
            applicationForm = applyForm;
            applyValuesJS = "javascript:" + $"document.getElementById('multichoice_23').value = {applicationForm.CourseNumber};" +
            $"document.getElementById('textfield_24').value = '{HttpUtility.JavaScriptStringEncode(applicationForm.DateOfApplication)}';" +
            $"document.getElementById('textfield_6').value = '{HttpUtility.JavaScriptStringEncode(applicationForm.Name)}';"+
            $"document.getElementById('textarea_8').value = '{HttpUtility.JavaScriptStringEncode(applicationForm.Address)}';" +
            $"document.getElementById('textfield_9').value = '{HttpUtility.JavaScriptStringEncode(applicationForm.DOB)}';" +
            $"document.getElementById('textfield_7').value = '{HttpUtility.JavaScriptStringEncode(applicationForm.email)}';" +
            $"document.getElementById('textfield_10').value = '{HttpUtility.JavaScriptStringEncode(applicationForm.HomeNumber)}';" +
            $"document.getElementById('textfield_11').value = '{HttpUtility.JavaScriptStringEncode(applicationForm.MobileNumber)}';" +
            $"document.getElementById('textarea_20').value = '{HttpUtility.JavaScriptStringEncode(applicationForm.SchoolCollege)}';" +
            $"document.getElementById('textarea_22').value = '{HttpUtility.JavaScriptStringEncode(applicationForm.Qualifications)}';" +
            $"document.getElementById('textfield_13').value = '{HttpUtility.JavaScriptStringEncode(applicationForm.SCN)}';" +
            $"document.getElementById('textarea_18').value = '{HttpUtility.JavaScriptStringEncode(applicationForm.ReasonForApplication)}';" +
            $"document.getElementById('textfield_19').value = '{HttpUtility.JavaScriptStringEncode(applicationForm.WhereDidYouHear)}';" +
            $"document.getElementById('textfield_15').value = '{HttpUtility.JavaScriptStringEncode(applicationForm.EmployerName)}';" +
            $"document.getElementById('textarea_16').value = '{HttpUtility.JavaScriptStringEncode(applicationForm.EmployerAddress)}';" +
            $"document.getElementById('textfield_17').value = '{HttpUtility.JavaScriptStringEncode(applicationForm.EmployerNumber)}';";

            submitValuesJS = "javascript:" + $"document.getElementsByName('savevalues')[0].click();";

            CourseLabel.Text = "Course: \n" + applyPage1ViewModel.CoursePickerList[applicationForm.CourseNumber - 1];
            NameLabel.Text = "Name: \n" + applicationForm.Name;
            AddressLabel.Text = "Address: \n" + applicationForm.Address;
            DOBLabel.Text = "Date of Birth: \n" + applicationForm.DOB;
            EmailLabel.Text = "Email: \n" + applicationForm.email;
            HomeTelLabel.Text = "Home Telephone: \n" + applicationForm.HomeNumber;
            MobilTelLabel.Text = "Mobile Telephone: \n" + applicationForm.MobileNumber;

            SchoolLabel.Text = "School: \n" + applicationForm.SchoolCollege;
            QualLabel.Text = "Qualifications: \n" + applicationForm.Qualifications;
            SCNLabel.Text = "Scottish Candidate Number: \n" + applicationForm.SCN;
            ReasonForApplyLabel.Text = "Reason For Applying: \n" + applicationForm.ReasonForApplication;
            HearLabel.Text = "Where did you hear about this course: \n" + applicationForm.WhereDidYouHear;

            employerNameLabel.Text = "Employer Name: \n" + applicationForm.EmployerName;
            EmployerAddressLabel.Text = "Employer Address: \n" + applicationForm.EmployerAddress;
            EmployerContactLabel.Text = "Employer Contact: \n" + applicationForm.EmployerNumber;








        }

        private async void Button_ClickedAsync(object sender, EventArgs e)
        {
                //submit script here and validate
                //await _webView.EvaluateJavaScriptAsync(applyValuesJS);
                

        }

        private async void _webView_Navigated(object sender, WebNavigatedEventArgs e)
        {
           
            await _webView.EvaluateJavaScriptAsync(applyValuesJS);
           
        }




        //document.getElementsByName('savevalues')[0].click() saves and uploads values

    }
}
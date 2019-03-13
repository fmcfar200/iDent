using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;


using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using iDent.Models;

namespace iDent.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ApplyPageReview : ContentPage
	{
        ApplicationForm applicationForm = new ApplicationForm();
        string script;
		public ApplyPageReview (ApplicationForm applyForm)
		{
			InitializeComponent ();
            applicationForm = applyForm;
            script = "javascript:" + $"document.getElementById('multichoice_23').value = {applicationForm.CourseNumber};" +
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




        }

        private async void Button_ClickedAsync(object sender, EventArgs e)
        {
                await _webView.EvaluateJavaScriptAsync(script);

        }




        //document.getElementsByName('savevalues')[0].click() saves and uploads values

    }
}
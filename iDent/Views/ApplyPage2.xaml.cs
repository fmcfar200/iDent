using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using iDent.Models;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace iDent.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ApplyPage2 : ContentPage
	{
        ApplicationForm applicationForm = new ApplicationForm();
		public ApplyPage2 (ApplicationForm appForm)
		{
			InitializeComponent ();
            applicationForm = appForm;

                   
		}

        async void OnNextPageButtonClicked(object sender, EventArgs e)
        {
            bool allValid = ReasonsBehaviour.isValid && WhereDidYouHearBehaviour.isValid;
            if(allValid)
            {
                applicationForm.SchoolCollege = SchoolEditor.Text;
                applicationForm.Qualifications = QualificationsEditor.Text;
                applicationForm.SCN = SCNEditor.Text;
                applicationForm.ReasonForApplication = ReasonsEditor.Text;
                applicationForm.WhereDidYouHear = WhereDidYouHearEditor.Text;

                await Navigation.PushAsync(new ApplyPage3(applicationForm));
            }
            else
            {
                await DisplayAlert("Not All Fields are Valid", "Please ensure all information is correct", "Close");
                return;
            }
        }

        async void OnPreviousPageButtonClicked(object sender, EventArgs e)
        {
            await Navigation.PopAsync();
        }
    }
}
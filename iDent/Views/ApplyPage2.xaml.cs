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

            RefreshFormValues(applicationForm);

                   
		}

        private void RefreshFormValues(ApplicationForm applicationForm)
        {
            SchoolEditor.Text = applicationForm.SchoolCollege;
            QualificationsEditor.Text = applicationForm.Qualifications;
            SCNEditor.Text = applicationForm.SCN;
            WhereDidYouHearEditor.Text = applicationForm.WhereDidYouHear;
            ReasonsEditor.Text = applicationForm.ReasonForApplication;
        }

        private void SaveValuesToApplyObject()
        {
            applicationForm.SchoolCollege = SchoolEditor.Text;
            applicationForm.Qualifications = QualificationsEditor.Text;
            applicationForm.SCN = SCNEditor.Text;
            applicationForm.ReasonForApplication = ReasonsEditor.Text;
            applicationForm.WhereDidYouHear = WhereDidYouHearEditor.Text;
        }


        async void OnNextPageButtonClicked(object sender, EventArgs e)
        {
            bool allValid = ReasonsBehaviour.isValid && WhereDidYouHearBehaviour.isValid;
            if(allValid)
            {
                SaveValuesToApplyObject();

                await Navigation.PushAsync(new ApplyPage3(applicationForm));
                MessagingCenter.Subscribe<ApplyPage3, ApplicationForm>(this, "GetApplicationPayload", (messageSender, arg) =>
                {
                    applicationForm = arg;
                });
            }
            else
            {
                await DisplayAlert("Not All Fields are Valid", "Please ensure all information is correct", "Close");
                return;
            }
        }

        async void OnPreviousPageButtonClicked(object sender, EventArgs e)
        {
            SaveValuesToApplyObject();
            MessagingCenter.Send<ApplyPage2, ApplicationForm>(this, "GetApplicationPayload", applicationForm);
            await Navigation.PopAsync();
        }
    }
}
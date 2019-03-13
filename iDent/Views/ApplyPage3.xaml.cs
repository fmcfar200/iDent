using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using iDent.Models;

namespace iDent.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ApplyPage3 : ContentPage
	{
        ApplicationForm applicationForm = new ApplicationForm();

		public ApplyPage3 ( ApplicationForm appForm)
		{
			InitializeComponent ();
            applicationForm = appForm;

            RefreshValues(applicationForm);
		}

        private void RefreshValues(ApplicationForm applicationForm)
        {
            EmployerNameEntry.Text = applicationForm.EmployerName;
            EmployerAddressEntry.Text = applicationForm.EmployerAddress;
            EmployerContactEntry.Text = applicationForm.EmployerNumber;
        }

        private void SaveValuesToApplyObject()
        {
            applicationForm.EmployerName = EmployerNameEntry.Text;
            applicationForm.EmployerAddress = EmployerAddressEntry.Text;
            applicationForm.EmployerNumber = EmployerContactEntry.Text;
        }

        async void OnReviewPageButtonClicked(object sender, EventArgs e)
        {


            SaveValuesToApplyObject();

            System.Diagnostics.Debug.WriteLine(
                    applicationForm.CourseNumber + "\n" +
                    applicationForm.DateOfApplication + "\n" +
                    applicationForm.Name + "\n" + "\n" +
                    applicationForm.Address + "\n" + "\n" +
                    applicationForm.DOB + "\n" +
                    applicationForm.email + "\n" +
                    applicationForm.HomeNumber + "\n" +
                    applicationForm.MobileNumber
                    + "\n \n" +
                    applicationForm.SchoolCollege + "\n" +
                    applicationForm.Qualifications + "\n" +
                    applicationForm.SCN + "\n" + "\n" +
                    applicationForm.ReasonForApplication + "\n" + "\n" +
                    applicationForm.WhereDidYouHear
                    + "\n \n" +
                    applicationForm.EmployerName + "\n" +
                    applicationForm.EmployerAddress + "\n" +
                    applicationForm.EmployerNumber
                   
                    );

            await Navigation.PushAsync(new ApplyPageReview(applicationForm));




        }

        async void OnPreviousPageButtonClicked(object sender, EventArgs e)
        {
            SaveValuesToApplyObject();
            MessagingCenter.Send<ApplyPage3, ApplicationForm>(this, "GetApplicationPayload", applicationForm);
            await Navigation.PopAsync();
        }

        
    }
}
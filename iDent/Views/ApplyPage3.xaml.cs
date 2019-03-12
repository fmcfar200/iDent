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
		}

        async void OnNextPageButtonClicked(object sender, EventArgs e)
        {
            string employerStreetNameNumber = EmployerStreetNumberEntry.Text + " " + EmployerStreetNameEntry.Text;
            string employerTown = EmployerTownEntry.Text;
            string emplyerCounty = EmployerCountyEntry.Text;
            string emplyerCountry = EmployerCountryEntry.Text;
            string employerPostcode = EmployerPostcodeEntry.Text;

            applicationForm.EmployerName = EmployerNameEntry.Text;

            applicationForm.EmployerAddress =
                employerStreetNameNumber + "\n" +
                employerTown + "\n" +
                emplyerCounty + "\n" +
                emplyerCountry + "\n" +
                employerPostcode;

            applicationForm.EmployerNumber = EmployerContactEntry.Text;


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




        }

        async void OnPreviousPageButtonClicked(object sender, EventArgs e)
        {
            await Navigation.PopAsync();
        }
    }
}
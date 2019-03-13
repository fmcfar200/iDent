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
	public partial class ApplyPageReview : ContentPage
	{
        ApplicationForm applicationForm = new ApplicationForm();
        string script;
		public ApplyPageReview (ApplicationForm applyForm)
		{
			InitializeComponent ();
            applicationForm = applyForm;
            script = "javascript:" + //$"document.getElementById('multichoice_23').value = {applicationForm.CourseNumber};" +
            //$"document.getElementById('textfield_24').value = {applicationForm.DateOfApplication.ToString()};" +
            $"document.getElementById('textfield_6').value = fraser;";
           //$"document.getElementById('textarea_8').value = {applicationForm.Address};" +
           //$"document.getElementById('textfield_9').value = {applicationForm.DOB};" +
           //$"document.getElementById('textfield_7').value = {applicationForm.email};" +
           //$"document.getElementById('textfield_10').value = {applicationForm.HomeNumber};" +
           //$"document.getElementById('textfield_11').value = {applicationForm.MobileNumber};" +
           //$"document.getElementById('textarea_20').value = {applicationForm.SchoolCollege};" +
           //$"document.getElementById('textarea_22').value = {applicationForm.Qualifications};" +
           //$"document.getElementById('textfield_13').value = {applicationForm.SCN};" +
           //$"document.getElementById('textarea_18').value = {applicationForm.ReasonForApplication};" +
           //$"document.getElementById('textfield_19').value = {applicationForm.WhereDidYouHear};" +
           //$"document.getElementById('textfield_15').value = {applicationForm.EmployerName};" +
           //$"document.getElementById('textarea_16').value = {applicationForm.EmployerAddress};" +
           //$"document.getElementById('textfield_17').value = {applicationForm.EmployerNumber};";




        }

        private void Button_ClickedAsync(object sender, EventArgs e)
        {
            Task.Run(async () =>
            {
            });
        }




        //document.getElementsByName('savevalues')[0].click() saves and uploads values

    }
}
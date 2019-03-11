using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using iDent;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace iDent.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ApplyPage2 : ContentPage
	{
		public ApplyPage2 (Models.ApplicationForm applicationForm)
		{
			InitializeComponent ();
            System.Diagnostics.Debug.WriteLine(applicationForm.CourseNumber);
           
           
            
            
		}

        async void OnNextPageButtonClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ApplyPage3());
        }

        async void OnPreviousPageButtonClicked(object sender, EventArgs e)
        {
            await Navigation.PopAsync();
        }
    }
}
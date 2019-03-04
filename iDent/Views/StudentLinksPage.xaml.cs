using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using iDent.Models;

namespace iDent.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class StudentLinksPage : ContentPage
	{
        private ObservableCollection<Link> linksCollection = new ObservableCollection<Link>();

		public StudentLinksPage ()
		{
			InitializeComponent ();
            linksCollection.Add(new Link("http://www.identtraining.com/","Ident Training.com","Gallery03.png"));
            linksCollection.Add(new Link("https://moodle.com/", "Moodle.com", "moodle.png"));


            LinksListView.ItemsSource = linksCollection;
            LinksListView.ItemTapped += (sender, e) =>
            {
                Link link = (Link)e.Item;
                Device.OpenUri(new Uri(link.URL));
       
            };


        }

        
	}
}
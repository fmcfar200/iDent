using iDent.Models;
using System;
using System.Windows.Input;
using System.Collections.ObjectModel;

using Xamarin.Forms;

namespace iDent.ViewModels
{
    class GalleryViewModel : BaseViewModel
    {
        public GalleryViewModel()
        {
            Title = "Gallery";
            Slides = new ObservableCollection<Slide>(new[]
            {
                new Slide("Gallery01.png","This is the desciption of Gallery01.png"),
                new Slide("Gallery02.png","This is the desciption of Gallery02.png"),
                new Slide("Gallery03.png","This is the desciption of Gallery03.png"),
                new Slide("DentalNursing.jpg","This is the description of DentalNursing.jpg")

            });
        }

        public ObservableCollection<Slide> Slides { get;}
    }
}

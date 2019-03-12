using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using iDent.Models;

namespace iDent.ViewModels
{
    class ApplyPage1ViewModel : BaseViewModel
    {

        public ApplyPage1ViewModel()
        {
            Title = "Application";
            CoursePickerList = new List<string>
            {
                "Dental Nursing",
                "Dental Administrator",
                "Medical and Dental Reception Award",
                "Prepare Practice for Inspection PDA",
                "Other"
            };

          
        }
        

        public List<string> CoursePickerList { get; }
    }
}

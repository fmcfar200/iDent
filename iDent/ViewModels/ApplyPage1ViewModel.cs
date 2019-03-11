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

    public interface IValidationRule<T>
    {
        string ValidationMessage { get; set; }
        bool Check(T value);
    }

    public class IsNotNullOrEmptyRule<T> : IValidationRule<T>
    {
        public string ValidationMessage { get; set; }

        public bool Check(T value)
        {
            if (value == null)
            {
                return false;
            }

            var str = value as string;
            return !string.IsNullOrWhiteSpace(str);
        }
    }

    public class EmailRule<T> : IValidationRule<T>
    {
        public string ValidationMessage { get; set; }

        public bool Check(T value)
        {
            if (value == null)
            {
                return false;
            }

            var str = value as string;
            Regex regex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
            Match match = regex.Match(str);

            return match.Success;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace iDent.Models
{
    public class ApplicationForm
    {
        public int CourseNumber { get; set; } = 0;
        public string DateOfApplication { get; set; } = "";
        public string Name { get; set; } = "";
        public string Address { get; set; } = "";
        public string DOB { get; set; } = "";
        public string email { get; set; } = "";
        public string HomeNumber { get; set; } = "";
        public string MobileNumber { get; set; } = "";

        public string SchoolCollege { get; set; } = "";
        public string Qualifications { get; set; } = "";
        public string SCN { get; set; } = "";
        public string ReasonForApplication { get; set; } = "";
        public string WhereDidYouHear { get; set; } = "";

        public string EmployerName { get; set; } = "";
        public string EmployerAddress { get; set; } = "";
        public string EmployerNumber { get; set; } = "";
    }
}

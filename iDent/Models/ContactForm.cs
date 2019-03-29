using System;
using System.Collections.Generic;
using System.Text;

namespace iDent.Models
{
    public class ContactForm
    {
        public string DateOfMessage { get; set; } = "";
        public string Name { get; set; } = "";
        public string Email { get; set; } = "";
        public string Message { get; set; } = "";

        public ContactForm()
        {
            DateOfMessage = DateTime.Now.Day.ToString() + "/" + DateTime.Now.Month.ToString() + "/" + DateTime.Now.Year.ToString();
        }

    }
}

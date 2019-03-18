using System;
using System.Collections.Generic;
using System.Text;

namespace iDent.Models
{
    public enum MenuItemType
    {
        Home,
        Apply,
        StudentLinks,
        MeetTheStaff,
        Gallery,
        Testimonials,
        ContactUs,
        About,
        Facebook,
        Twitter
    }
   
    public class HomeMenuItem
    {
        public MenuItemType Id { get; set; }

        public string Title { get; set; }
        public string Icon { get; set; }
    }
}

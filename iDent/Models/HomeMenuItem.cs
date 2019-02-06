using System;
using System.Collections.Generic;
using System.Text;

namespace iDent.Models
{
    public enum MenuItemType
    {
        Browse,
        Home,
        Apply,
        UsefulLinks,
        MeetTheStaff,
        Gallery,
        Testimonials,
        ContactUs,
        About
    }
    public class HomeMenuItem
    {
        public MenuItemType Id { get; set; }

        public string Title { get; set; }
    }
}

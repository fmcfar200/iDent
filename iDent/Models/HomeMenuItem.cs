using System;
using System.Collections.Generic;
using System.Text;

namespace iDent.Models
{
    public enum MenuItemType
    {
        Browse,
        Home,
        UsefulLinks,
        MeetTheStaff,
        Gallery,
        Testimonials,
        About
    }
    public class HomeMenuItem
    {
        public MenuItemType Id { get; set; }

        public string Title { get; set; }
    }
}

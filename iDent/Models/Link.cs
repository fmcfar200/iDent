using System;
using System.Collections.Generic;
using System.Text;

namespace iDent.Models
{
    class Link
    {
        public string URL { get; set; }
        public string LinkTitle { get; set; }
        public string LinkImage { get; set; }

        public Link(string url, string linkTitle, string linkImage)
        {
            this.URL = url;
            this.LinkTitle = linkTitle;
            this.LinkImage = linkImage;
        }
    }
}

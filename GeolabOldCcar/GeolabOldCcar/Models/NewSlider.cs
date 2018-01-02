using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GeolabOldCcar.Models
{
    public class NewSlider
    {
        public int id { get; set; }
        public DateTime Date { get; set; }
        public HttpPostedFileBase file1 { get; set; }
        public string Title { get; set; }

    }
}
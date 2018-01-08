using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GeolabOldCcar.Models
{
    public class IndexModel
    {
        public List<Slider> SliderList { get; set; }
        public List<Social> SocialList { get; set; }
        public List<Icon> IconList { get; set; }
public IndexModel()
        {
            SliderList = new List<Slider>();
            SocialList = new List<Social>();
            IconList = new List<Icon>();
        }
    }
}
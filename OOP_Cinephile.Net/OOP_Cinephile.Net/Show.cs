using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Cinephile.Net
{
    public class Show
    {
        public string Name { get; set; }
        public string Genre { get; set; }
        public int Rating
        {
            get { return Rating; }
            set { Rating = (value >= 0 && value <= 10) ? value : Rating; }
        }

        public string Review { get; set; }

        public Show()
        {
            
        }
    }
}


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
        public int Rating { get; set; }
        

        public string Review { get; set; }
        public ListType ListType { get; set; }

        public Show(string name, string genre, int rating, string review)
        {
            this.Name = name;
            this.Genre = genre;
            this.Rating = rating;
            this.Review = review;
        }

        public Show()
        {
        }
    }
}


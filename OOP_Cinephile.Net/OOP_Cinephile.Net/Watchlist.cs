using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Cinephile.Net
{
    public class Watchlist
    {
        private List<Show> shows;

        public Watchlist()
        {
            this.shows = new List<Show>();
        }

        public void AddShow(Show show)
        {
            shows.Add(show);
        }

        public void RemoveShow(Show show)
        {
            shows.Remove(show);
        }

        public void ModifyRating(string showName, int rating)
        {
            Show show = shows.Find(s => s.Name == showName);
            if (show != null)
            {
                show.Rating = rating;
            }
        }

        public void ModifyReview(string showName, string review)
        {
            Show show = shows.Find(s => s.Name == showName);
            if (show != null)
            {
                show.Review = review;
            }
        }

        public void SortAlphabetically()
        {
            shows.Sort((s1, s2) => s1.Name.CompareTo(s2.Name));
        }

        public void SortByGenre()
        {
            shows.Sort((s1, s2) => s1.Genre.CompareTo(s2.Genre));
        }

        public void SortByRating()
        {
            shows.Sort((s1, s2) => s2.Rating.CompareTo(s1.Rating));
        }
    }
}


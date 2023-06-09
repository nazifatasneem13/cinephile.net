﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Cinephile.Net
{
    public class User
    {
        private int age;
        private string name;
        private string email;
        private List<Watchlist> watchlists;
        private decimal balance;
        public bool isPublic;
        public User()
        {

        }

        public User(int age, string name, string email, bool isPublic)
        {
            Form6 form6 = new Form6();
            this.age = age;
            this.name = name;
            this.email = email;
            this.watchlists = new List<Watchlist>();
            this.balance = 0;
            this.isPublic = isPublic;
        }

        public void AddWatchlist(Watchlist watchlist)
        {
            watchlists.Add(watchlist);
        }

        public void RemoveWatchlist(Watchlist watchlist)
        {
            watchlists.Remove(watchlist);
        }

        public void ModifyRating(string showName, string rating)
        {
            foreach (Watchlist watchlist in watchlists)
            {
                watchlist.ModifyRating(showName, rating);
            }
        }

        public void ModifyReview(string showName, string review)
        {
            foreach (Watchlist watchlist in watchlists)
            {
                watchlist.ModifyReview(showName, review);
            }
        }
    }
}


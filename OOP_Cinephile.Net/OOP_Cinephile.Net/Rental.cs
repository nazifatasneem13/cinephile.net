using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Cinephile.Net
{
    internal class Rental
    {
        private string showName;
        private DateTime rentalDate;
        private DateTime dueDate;
        public Rental(string showName, DateTime rentalDate, int rentalDays)
        {
            this.showName = showName;
            this.rentalDate = rentalDate;
            this.dueDate = rentalDate.AddDays(rentalDays);
        }

        public bool HasExpired()
        {
            return DateTime.Now > dueDate;
        }

        public void ReturnShow()
        {

        }
    }
}
}

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_Cinephile.Net
{
    public class Rental
    {
        Show show = new Show();
        
        public string showName;
        public int initial_balance;
        DateTime rentalDate;
        DateTime dueDate;
        public bool IsRented;
        public int price;
   
        public void rental()
        {
           
        }

        public bool HasExpired()
        {
            return DateTime.Now > dueDate;
        }

        public string ReturnShow()
        {
            return showName;
        }
        public void RentShow(int initial_balance)
        {
            if (IsRented)
            {
                MessageBox.Show("This show is already rented.");
                return;
            }

            if (initial_balance >= price && IsRented == false)
            {
                
                dueDate = DateTime.Now.AddDays(7);
                MessageBox.Show("Show rented successfully.");
            }
            else if (initial_balance < price)
            {
                MessageBox.Show("Insufficient balance to rent the show.");
            }
        }
        public void BuyShow(int initial_balance)
        {
            if (initial_balance >= price)
            {
                MessageBox.Show("Show purchased successfully.");
            }
            else if (initial_balance < price)
            {
                MessageBox.Show("Insufficient balance to buy the show.");
            }
        }
    }
}


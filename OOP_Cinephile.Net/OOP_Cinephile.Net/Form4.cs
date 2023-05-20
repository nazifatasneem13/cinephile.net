using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_Cinephile.Net
{
    public partial class Form4 : Form
    {
        Rental rental = new Rental();
        List<Show> shows = new List<Show>();
        Show s = new Show();
        //string initial_balance = Convert.ToInt32(textBox4.Text);
        public Form4()
        {
            InitializeComponent();
        }

        //private void button7_Click(object sender, EventArgs e)
        //{
        //    Form3 f3 = new Form3();
        //    f3.Show();
        //    this.Hide();
        //}

        private void button8_Click(object sender, EventArgs e)
        {
            Form6 f6 = new Form6();
            f6.Show();
            this.Hide();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            rental.initial_balance = Convert.ToInt32(textBox4.Text);
            rental.price = Convert.ToInt32(textBox1.Text);
            rental.showName = textBox2.Text;
            s.Name = textBox2.Text;
            foreach (Show s in shows)
            {
                if (shows.Contains(s))
                {
                    rental.IsRented = true;
                }
                else
                {
                    rental.IsRented = false;
                }
            }
            
            shows.Add(s);
            
            if(comboBox2.Text == "Rent")
            {
                
                rental.RentShow(rental.initial_balance);
            }
            else if (comboBox2.Text == "Buy")
            {
                rental.BuyShow(rental.initial_balance);
            }
            rental.initial_balance = rental.initial_balance - rental.price;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            rental.initial_balance = Convert.ToInt32(textBox4.Text);
            rental.price = Convert.ToInt32(textBox1.Text);
            rental.initial_balance = rental.initial_balance - rental.price;
            MessageBox.Show($"Your balance is {rental.initial_balance}.");

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form5 form5= new Form5();
            form5.Show();
            this.Hide();

        }
    }
}

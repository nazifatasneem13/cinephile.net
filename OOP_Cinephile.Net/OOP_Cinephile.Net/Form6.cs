using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace OOP_Cinephile.Net
{
    public partial class Form6 : Form
    {
        private bool ispublic;
        
        public Form6()
        {
            //bool ispublic = isPublic;
           InitializeComponent();
        }

        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            f3.Show();
            this.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Form4 f4 = new Form4();      
            f4.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            User user = new User();
            Form3 form3 = new Form3();
            string[] lines = File.ReadAllLines("Credentials.txt");
            foreach (string line in lines)
            {
                string[] fields = line.Split(',');

                if (fields[0] == textBox4.Text)
                {
                    if (form3.userName == fields[0])
                    {
                        foreach (string field in fields)
                        {
                            if (ispublic == false)
                            {
                                MessageBox.Show("This account is private.");
                            }
                            else if (ispublic == true)
                            {
                                showListBox.DataSource = form3.planToWatchList;
                                showListBox.DataSource = form3.watchedList;
                                showListBox.DataSource = form3.droppedList;
                                showListBox.DataSource = form3.favoritesList;
                            }
                        }
                    }
                }
            }
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void showListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

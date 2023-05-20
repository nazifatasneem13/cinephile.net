using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_Cinephile.Net
{
    public partial class Form1 : Form
    {
       
        public Form1()
        {
            InitializeComponent();
            
        }
        

        private void LogIn_Click(object sender, EventArgs e)
        {
            string name = NameTB.Text;
            string age = AgeTB.Text;
            string email = MailTB.Text;
            string password = PasswordTB.Text;

            // Check if the user's credentials are valid
            bool isValid = CheckCredentials(name, age, email, password);

            if (isValid)
            {
                // Redirect to Form3
                Form3 form3 = new Form3(name,age);
                form3.Show();
                this.Hide();
            }
            else
            {
                // Show an error message
                MessageBox.Show("Incorrect username, age, email or password!");
            }
        }
        private bool CheckCredentials(string name, string age, string email, string password)
        {
            // Check if the user's credentials match a record in the text file
            string[] lines = File.ReadAllLines("Credentials.txt");

            foreach (string line in lines)
            {
                string[] fields = line.Split(',');

                if (fields[0] == name && fields[1] == age && fields[2] == email && fields[3] == password)
                {
                    return true;
                }
            }

            return false;
        }

        private void F1Next_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Show();
            this.Hide();
        }

        private void CreateAccount_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Show();
            this.Hide();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}

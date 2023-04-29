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
            int age;
            string email = MailTB.Text;
            string password = PasswordTB.Text;

            // Read the user data from the text file
            List<string> userData = File.ReadAllLines("Credentials.txt").ToList();

            // Check if the user data matches any of the saved user data
            bool isValid = false;
            foreach (string user in userData)
            {
                string[] parts = user.Split(',');
                if (parts[0] == name && parts[1] == AgeTB.Text && parts[2] == email && parts[3] == password)
                {
                    isValid = true;
                    break;
                }
            }

            if (isValid)
            {
                // Redirect to Form3
                Form3 form3 = new Form3(name);
                form3.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Incorrect username, age, email or password!");
            }
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
    }
}

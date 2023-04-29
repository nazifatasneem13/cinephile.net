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
    public partial class Form2 : Form
    {
       
        public Form2()
        {
            InitializeComponent();
        }

       
        private void SignUp_Click(object sender, EventArgs e)
        {
            string name = NameTB1.Text;
            int age;
            string email = MailTB1.Text;
            string password = PasswordTB1.Text;
            string retypePassword = RePassTB.Text;

            // Check if the user name already exists
            List<string> userData = File.ReadAllLines("Credentials.txt").ToList();
            bool userExists = userData.Any(user => user.Split(',')[0] == name);

            // Check if the passwords match
            bool passwordsMatch = password == retypePassword;

            // Check if the name and password are at least six characters long
            bool nameValid = name.Length >= 6;
            bool passwordValid = password.Length >= 6;

            if (userExists)
            {
                MessageBox.Show("A user with the same name already exists");
            }
            else if (!passwordsMatch)
            {
                MessageBox.Show("Passwords do not match");
            }
            else if (!nameValid || !passwordValid)
            {
                MessageBox.Show("Name and password must be at least six characters");
            }
            else
            {
                // Save the user data to the text file
                string userDataString = $"{name},{AgeTB1.Text},{email},{password}";
                File.AppendAllText("Credentials.txt", $"{userDataString}{Environment.NewLine}");

                // Redirect to Form1
                Form1 form1 = new Form1();
                form1.Show();
                this.Hide();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            f3.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
            this.Hide();
        }
    }
}

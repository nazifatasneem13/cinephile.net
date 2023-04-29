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
        private const string UserFilePath = "Credentials.txt";
        public Form2()
        {
            InitializeComponent();
        }

        private bool ValidateInputs()
        {
            // check if username already exists
            string name = NameTB1.Text.Trim();
            if (File.Exists(UserFilePath))
            {
                string[] userLines = File.ReadAllLines(UserFilePath);
                foreach (string userLine in userLines)
                {
                    string[] userFields = userLine.Split(',');
                    if (userFields.Length == 4 && userFields[0] == name) // ensure file format is correct
                    {
                        MessageBox.Show("A user with the same user name already exists");
                        return false;
                    }
                }
            }

            // check if username and password are at least six characters long
            if (name.Length < 6 || PasswordTB1.Text.Length < 6)
            {
                MessageBox.Show("Username and password must be at least six characters");
                return false;
            }

            // check if password and re-typed password match
            if (PasswordTB1.Text != RePassTB.Text)
            {
                MessageBox.Show("Passwords do not match");
                return false;
            }

            return true;
        }
        private void SignUp_Click(object sender, EventArgs e)
        {
            if (ValidateInputs())
            {
                // save user to file
                string name = NameTB1.Text.Trim();
                string password = PasswordTB1.Text;
                int age = Convert.ToInt32(AgeTB1.Text);
                string mail = MailTB1.Text;


                string userLine = string.Format("{0},{1},{2},{3}", name, password, age, mail);
                File.AppendAllLines(UserFilePath, new string[] { userLine });

                Form1 f1 = new Form1();
                f1.Show();
                this.Hide();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Show();
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

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
            string age = AgeTB1.Text;
            string email = MailTB1.Text;
            string password = PasswordTB1.Text;
            string retypePassword = RePassTB.Text;
            

            // Check if the name is unique
            if (IsNameUnique(name))
            {
                // Check if the password and retype password match
                if (password == retypePassword)
                {
                    // Check if the email is valid
                    if (IsValidEmail(email))
                    {
                        // Add the user to the text file
                        string line = $"{name},{age},{email},{password}";
                        File.AppendAllText("Credentials.txt", $"{line}{Environment.NewLine}");

                        // Redirect to Form1
                        Form1 form1 = new Form1();
                        form1.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Invalid Email!Must contain @.");
                    }
                }
                else
                {
                    MessageBox.Show("Passwords do not match");
                }
            }
            else
            {
                MessageBox.Show("A user with the same name already exists");
            }
        }
        private bool IsNameUnique(string name)
        {
            // Check if the name already exists in the text file
            string[] lines = File.ReadAllLines("Credentials.txt");

            foreach (string line in lines)
            {
                string[] fields = line.Split(',');

                if (fields[0] == name)
                {
                    return false;
                }
            }

            return true;
        }

        private bool IsValidEmail(string email)
        {
            // Check if the email contains the "@" character
            return email.Contains("@");
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

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }

        private void Form2_Enter(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, pictureBox1.ClientRectangle, Color.Black, ButtonBorderStyle.Solid);
        }
    }
}

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
        private Dictionary<string, string> UserDict = new Dictionary<string, string>();//usernames are key,passwords are value

        private const string UserFilePath = "Credentials.txt";
        public Form1()
        {
            InitializeComponent();
            LoadUsersFromFile();
        }
        private void LoadUsersFromFile()
        {
            if (File.Exists(UserFilePath))
            {
                string[] userLines = File.ReadAllLines(UserFilePath);
                foreach (string userLine in userLines)
                {
                    string[] userFields = userLine.Split(',');
                    if (userFields.Length == 4) // ensure file format is correct
                    {
                        string name = userFields[0];
                        string password = userFields[1];
                        UserDict.Add(name, password);


                    }
                }
            }
        }

        private void LogIn_Click(object sender, EventArgs e)
        {
            string name = NameTB.Text.Trim();//whitespace characters get rejected
            string password = PasswordTB.Text;

            if (UserDict.ContainsKey(name) && UserDict[name] == password)
            {
                // successful login
                Form3 f3 = new Form3(name);
                f3.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Incorrect username or password!");
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

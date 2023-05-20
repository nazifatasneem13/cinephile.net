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
    public enum ListType
    {
        PlanToWatch,
        Watched,
        Dropped,
        Favorites
    }
    public partial class Form3 : Form
    {
        private string userName;
        private List<Show> planToWatchList;
        private List<Show> watchedList;
        private List<Show> droppedList;
        private List<Show> favoritesList;
        public Form3()
        {
        }
        
        public Form3(string name)
        {
            InitializeComponent();
            userName = name;
            
            label3.Text = $"Welcome, {name}!";
            planToWatchList = new List<Show>();
            watchedList = new List<Show>();
            droppedList = new List<Show>();
            favoritesList = new List<Show>();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Form4 f4 = new Form4();
            f4.Show();
            this.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string showName = ShowNameTB.Text;
            string genre = GenreTB.Text;
            string rating = RatingTB.Text;
            string review = ReviewTB.Text;

            MessageBox.Show("Please hoose where to add the show.", "Add Show", MessageBoxButtons.OK, MessageBoxIcon.Question);

            addToListComboBox.Items.Clear();
            addToListComboBox.Items.AddRange(new object[] { "Plan to Watch", "Watched", "Dropped", "Favorites" });
            addToListComboBox.SelectedIndex = 0;
            addToListComboBox.Visible = true;
            AddtoSelectedList.Visible = true;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form5 f5 = new Form5();
            f5.Show();
            this.Hide();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DisplayShowList(planToWatchList, "Plan to Watch Shows");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DisplayShowList(watchedList, "Watched Shows");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DisplayShowList(droppedList, "Dropped Shows");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DisplayShowList(favoritesList, "Favorite Shows");
        }

        private void AddtoSelectedList_Click(object sender, EventArgs e)
        {
            string selectedListType = addToListComboBox.SelectedItem.ToString();
            Show show = new Show(ShowNameTB.Text, GenreTB.Text, RatingTB.Text, ReviewTB.Text);

            switch (selectedListType)
            {
                case "Plan to Watch":
                    planToWatchList.Add(show);
                    break;
                case "Watched":
                    watchedList.Add(show);
                    break;
                case "Dropped":
                    droppedList.Add(show);
                    break;
                case "Favorites":
                    favoritesList.Add(show);
                    break;
            }

            MessageBox.Show("Show added successfully");
            ShowNameTB.Text = string.Empty;
            GenreTB.Text = string.Empty;
            RatingTB.Text = string.Empty;
            ReviewTB.Text = string.Empty;
        }
        private void DisplayShowList(List<Show> showList, string listName)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"--- {listName} ---");

            foreach (Show show in showList)
            {
                sb.AppendLine($"Name: {show.Name}");
                sb.AppendLine($"Genre: {show.Genre}");
                sb.AppendLine($"Rating: {show.Rating}");
                sb.AppendLine($"Review: {show.Review}");
                sb.AppendLine("-----------------------");
            }

            MessageBox.Show(sb.ToString());
        }
    }
}

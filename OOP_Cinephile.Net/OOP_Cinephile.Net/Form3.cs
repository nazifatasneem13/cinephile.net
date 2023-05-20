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
    
    public partial class Form3 : Form
    {
        public string userName;
        public string _age;
        public List<Show> planToWatchList;
        public List<Show> watchedList;
        public List<Show> droppedList;
        public List<Show> favoritesList;
        public Form3()
        {
        }
        
        public Form3(string name,string age)
        {
            InitializeComponent();
            userName = name;
            _age = age;
            
            label3.Text = $"Welcome, {name}!";
            planToWatchList = new List<Show>();
            watchedList = new List<Show>();
            droppedList = new List<Show>();
            favoritesList = new List<Show>();
            ratingcombobox.Items.Add("G");
            ratingcombobox.Items.Add("PG");
            ratingcombobox.Items.Add("PG-13");
            ratingcombobox.Items.Add("R");
            ratingcombobox.Items.Add("NC-17");

            // Populate the genreComboBox with options
            genrecombobox.Items.Add("Action");
            genrecombobox.Items.Add("Comedy");
            genrecombobox.Items.Add("Drama");
            genrecombobox.Items.Add("Fantasy");
            genrecombobox.Items.Add("Adventure");
            genrecombobox.Items.Add("Horror");
            genrecombobox.Items.Add("Mystery");
            genrecombobox.Items.Add("Psychological");
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

        public void button5_Click(object sender, EventArgs e)
        {
            string showName = ShowNameTB.Text;
            string genre = genrecombobox.Text;
            string rating = ratingcombobox.Text;
            string review = ReviewTB.Text;

            MessageBox.Show("Please choose where to add the show.", "Add Show", MessageBoxButtons.OK, MessageBoxIcon.Question);

            addToListComboBox.Items.Clear();
            addToListComboBox.Items.AddRange(new object[] { "Plan to Watch", "Watched", "Dropped", "Favorites" });
            
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
            string selectedGenre = genrecombobox.SelectedItem.ToString();
            List1(planToWatchList, $"Plan to Watch Shows - {selectedGenre}");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string selectedGenre = genrecombobox.SelectedItem.ToString();
            List2(watchedList,  $"Watched Shows - {selectedGenre}");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string selectedGenre = genrecombobox.SelectedItem.ToString();
            List3(droppedList, $"Dropped Shows - {selectedGenre}");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string selectedGenre = genrecombobox.SelectedItem.ToString();
            List4(favoritesList, $"Favorite Shows - {selectedGenre}");
        }

        public void AddtoSelectedList_Click(object sender, EventArgs e)
        {
            string selectedListType = addToListComboBox.SelectedItem.ToString();
            Show show = new Show(ShowNameTB.Text, genrecombobox.SelectedItem.ToString(), ratingcombobox.SelectedItem.ToString(), ReviewTB.Text);

            if(((ratingcombobox.SelectedItem.ToString() == "NC-17")|| (ratingcombobox.SelectedItem.ToString() == "R")) && int.Parse(_age) < 17)
            {
                MessageBox.Show("You are not old enough to select this rating!Please choose again.");
                ShowNameTB.Text = string.Empty;
                genrecombobox.Text = string.Empty;
                ratingcombobox.Text = string.Empty;
                ReviewTB.Text = string.Empty;
            }
            else
            {
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
                genrecombobox.Text = string.Empty;
                ratingcombobox.Text = string.Empty;
                ReviewTB.Text = string.Empty;
            }
             
        }
        
        public void List1(List<Show> showList,string listName)
        {
            planToWatchListBox.Items.Clear();
            planToWatchListBox.Items.Add("Name\tGenre\tRating\tReview");
            foreach (Show show in showList)
            {


                string showInfo = $"{show.Name}\t{show.Genre}\t{show.Rating}\t{show.Review}";
                planToWatchListBox.Items.Add(showInfo);

            }
        }
        public void List2(List<Show> showList, string listName)
        {
            WatchedListBox.Items.Clear();
            WatchedListBox.Items.Add("Name\tGenre\tRating\tReview");
            foreach (Show show in showList)
            {


                string showInfo = $"{show.Name}\t{show.Genre}\t{show.Rating}\t{show.Review}";
                WatchedListBox.Items.Add(showInfo);

            }
        }
        public void List3(List<Show> showList, string listName)
        {
            DroppedListBox.Items.Clear();
            DroppedListBox.Items.Add("Name\tGenre\tRating\tReview");
            foreach (Show show in showList)
            {


                string showInfo = $"{show.Name}\t{show.Genre}\t{show.Rating}\t{show.Review}";
                DroppedListBox.Items.Add(showInfo);

            }
        }
        public void List4(List<Show> showList, string listName)
        {
            FavoritesListBox.Items.Clear();
            FavoritesListBox.Items.Add("Name\tGenre\tRating\tReview");
            foreach (Show show in showList)
            {


                string showInfo = $"{show.Name}\t{show.Genre}\t{show.Rating}\t{show.Review}";
                FavoritesListBox.Items.Add(showInfo);

            }
        }



        private void WatchedListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void PlanButton_Click(object sender, EventArgs e)
        {
            planToWatchListBox.Items.Clear();
        }

        private void watchedButton_Click(object sender, EventArgs e)
        {
            WatchedListBox.Items.Clear();
        }

        private void droppedButton_Click(object sender, EventArgs e)
        {
            DroppedListBox.Items.Clear();
        }

        private void favoritesButton_Click(object sender, EventArgs e)
        {
            FavoritesListBox.Items.Clear();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4();
            form4.Show();
            this.Hide();
        }

        private void ratingcombobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
        private void DisplayShowList(List<Show> showList, string listName, ListBox listBox)
        {
            listBox.Items.Clear();
            listBox.Items.Add($"--- {listName} ---");

            foreach (Show show in showList)
            {
                listBox.Items.Add($"Name: {show.Name}");
                listBox.Items.Add($"Genre: {show.Genre}");
                listBox.Items.Add($"Rating: {show.Rating}");
                listBox.Items.Add($"Review: {show.Review}");
                listBox.Items.Add("-----------------------");
            }
        }

        private void ShowNameTB_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

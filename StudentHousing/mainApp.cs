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

namespace StudentHousing
{
    public partial class mainApp : Form
    {
        private User user;

        public mainApp(User user)
        {
            this.user = user;
            InitializeComponent();
            loadComponents();
            loadLists();
        }

        private void loadLists()
        {
            allAgreements.Items.Clear();
            searchListBox.Items.Clear();
            string[] temp = user.GetAllOfUserAgreements();
            foreach (string s in temp)
            {
                allAgreements.Items.Add(s);
                searchListBox.Items.Add(s);
            }
        }

        private void loadComponents()
        {
            usernamelbl.Text = user.Username;
            if (File.Exists(@"..\ProfilePictures\" + user.Username + ".png"))
            {
                profilePictureBox.ImageLocation = @"..\ProfilePictures\" + user.Username + ".png";
                uploadPicturebtn.Hide();
            }
            ruleslbl.Text = System.IO.File.ReadAllText(@"..\database\rules.txt");
            UsersDatabase temp = new UsersDatabase();
            string[] tempUsers = temp.GetAllUsersFromDatabase();
            foreach (string s in tempUsers)
            {
                if (s != user.Username)
                {
                    Userscbb.Items.Add(s);
                }
            }
            loadLists();
        }

        private void addAgrrementToList_Click(object sender, EventArgs e)
        {
            UsersDatabase temp = new UsersDatabase();
            string[] tempUsers = temp.GetAllUsersFromDatabase();

            if (Userscbb == null || !tempUsers.Contains(Userscbb.Text) || string.IsNullOrWhiteSpace(agreementtbx.Text))
                return;

            bool result = user.AddAgreement(usernamelbl.Text, Userscbb.Text, agreementtbx.Text);

            if (result)
            {
                MessageBox.Show("Successful!");
                loadLists();
            }
            else 
            MessageBox.Show("Not viable! The signs ; and _ are not allowed");
        }
        
        private void UploadComplaintbtn_Click(object sender, EventArgs e)
        {
            bool result = user.UploadComplaint(complainttbx.Text, user.Username);

            if (result)
            {
                MessageBox.Show("Your complaint was uploaded");
                complainttbx.Clear();
            }
            else
                MessageBox.Show("Not viable! The signs _ and ; are not allowed!");

        }

        private void searchbtn_Click(object sender, EventArgs e)
        {
            if(searchbtn.Text == "")
            {
                loadLists();
                return;
            }

            searchListBox.Items.Clear();
            List<string> temp = user.SearchAgreement(searchtbx.Text).ToList();
            foreach (string t in temp)
            {
                searchListBox.Items.Add(t);
            }
        }

        private void uploadPicturebtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Image Files(*.jpg; *.png;)|*.jpg; *.png;";
            if (open.ShowDialog() == DialogResult.OK)
            {
                //pictureBox1.Image = new Bitmap(open.FileName);
                string imageSource = open.FileName;
                File.Copy(imageSource, @"..\ProfilePictures\" + usernamelbl.Text + ".png");
                profilePictureBox.ImageLocation = @"..\ProfilePictures\" + usernamelbl.Text + ".png";
                uploadPicturebtn.Hide();
            }
        }

        private void SignOutlbl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Form1 form1 = new Form1();
            form1.ShowDialog();
            this.Close();
        }
    }
}

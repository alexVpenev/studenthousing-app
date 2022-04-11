using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentHousing
{
    public partial class Form1 : Form
    {
        private UsersDatabase database;

        public Form1() 
        {
            InitializeComponent();
            this.database = new UsersDatabase();
        }

        private void LogInbtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(usernametxb.Text) || string.IsNullOrWhiteSpace(passwordtxb.Text))
                return;

            User user = database.LogInUser(usernametxb.Text, passwordtxb.Text);

            if (user == null)
            {
                MessageBox.Show("Wrong username or password! Please Try again");
                usernametxb.Text = "";
                passwordtxb.Text = "";
                return;
            }

            this.Hide();
            mainApp app = new mainApp(user);
            app.ShowDialog();
            this.Close();
        }

        private void CreateUserbtn_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            CreateUser form = new CreateUser();
            form.ShowDialog();
            this.Close();
        }
    }
}

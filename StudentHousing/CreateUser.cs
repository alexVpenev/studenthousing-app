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
    public partial class CreateUser : Form
    {
        public CreateUser()
        {
            InitializeComponent();
        }

        private void CreateUserBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(newUsernametxb.Text) || string.IsNullOrWhiteSpace(newPasswordtxb.Text))
                return;

            UsersDatabase database = new UsersDatabase();

            if (!database.CheckIfNewProfileIsViable(newUsernametxb.Text, newPasswordtxb.Text))
            {
                MessageBox.Show("The sign _ is not allowed, also no numbers are allowed inside the password");
                return;
            }
            else if (!database.CheckIfUsernameIsFree(newUsernametxb.Text))
            {
                MessageBox.Show("An account with that Username already exists");
                return;
            }

            bool result = database.AddUser(newUsernametxb.Text, newPasswordtxb.Text);
            if (result)
            {
                MessageBox.Show("Your account is ready. You can Log in now!");
            }
                        
            this.Hide();
            Form1 form = new Form1();
            form.ShowDialog();
            this.Close();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentHousing
{
    class UsersDatabase
    {
        private List<User> usersList;
        private List<string> database = new List<string>();

        public UsersDatabase()
        {
            usersList = new List<User>();
            CreateTheExistingUsersToObjects();
        }

        private void CreateTheExistingUsersToObjects()
        {
            try
            {
                usersList.Clear();
                string[] usernames = GetAllUsersFromDatabase();
                string[] passwords = GetAllPasswordsFromDatabase();

                for (int i = 0; i < usernames.Count(); i++)
                {
                usersList.Add(new User(usernames[i], passwords[i]));
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Oops!? You touched where you shouldn't");
            }
        }
        public string[] GetAllUsersFromDatabase()
        {
            List<string> resultList = new List<string>();
            database = System.IO.File.ReadLines(@"..\database\database.txt").ToList();

            foreach (string line in database)
            {
                resultList.Add(line.Substring(0, line.IndexOf("_")));
                resultList.Add(line.Substring(line.IndexOf("_") + 1));
            }

            return resultList.ToArray();
        }
        private string[] GetAllPasswordsFromDatabase()
        {
            List<string> resultList = new List<string>();
            database = System.IO.File.ReadLines(@"..\database\database.txt").ToList();

            foreach (string line in database)
            {
                resultList.Add(line.Substring(line.IndexOf("_") + 1));
            }

            return resultList.ToArray();
        }
        public bool AddUser(string username, string password)
        {
            if (CheckIfNewProfileIsViable(username, password) && CheckIfUsernameIsFree(username))
            {
                System.IO.File.AppendAllText(@"..\database\database.txt", username + "_" + User.Encipher(password, 1) + Environment.NewLine);
                CreateTheExistingUsersToObjects();
                return true;
            }
            return false;
        }
        public bool CheckIfNewProfileIsViable(string username, string password)
        {
            return !username.Contains("_") || password.Contains("_") || password.Any(c => char.IsDigit(c));
            if (username.Contains("_") || password.Contains("_") || password.Any(c => char.IsDigit(c)))
                return false;

            return true;
        }
        public bool CheckIfUsernameIsFree(string username)
        {
            foreach (User user in usersList)
            {
                if (user.Username == username)
                    return false;
            }
            return true;
        }
        public User LogInUser(string username, string password)
        {
            foreach (User user in usersList)
            {
                if (user.Username == username && user.UserPassword == password)
                {
                    return user;
                }
            }

            return null;
        }
    }
}

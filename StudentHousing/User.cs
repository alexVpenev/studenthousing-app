using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentHousing
{
    public class User
    {
        private string username;
        private string userPassword;
        private string profilePictureLocation;
        private List<Agreement> agreementsList;

        public string Username { get; set; }
        public string UserPassword
        {
            get { return Decipher(userPassword, 1); }
            set { userPassword = value; }
        } 
        public string ProfilePictureLocation { get; set; }

        public User(string username, string userPassword)
        {
            Username = username;
            UserPassword = userPassword;
            ProfilePictureLocation = @"..\ProfilePictures\" + username + ".png";

            agreementsList = new List<Agreement>();
        }
        
        private void CreateExistingAgreementsToObjects()
        {
            try
            {
                agreementsList.Clear();
                string[] firstPartyArray = GetFirstPartyFromList();
                string[] secondPartyArray = GetSecondPartyFromList();
                string[] contentArray = GetContentFromList();

                for (int i = 0; i < firstPartyArray.Count(); i++)
                {
                    agreementsList.Add(new Agreement(firstPartyArray[i], secondPartyArray[i], contentArray[i]));
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Oops!? You touched where you shouldn't");
            }
        }
        private string[] GetFirstPartyFromList()
        {
            List<string> resultList = new List<string>();
            List<string> agreementsDatabase = System.IO.File.ReadLines(@"..\database\agreement.txt").ToList();

            foreach (string line in agreementsDatabase)
            {
                resultList.Add(line.Substring(0, line.IndexOf(";")));
            }
            return resultList.ToArray();
        }
        private string[] GetSecondPartyFromList()
        {
            List<string> resultList = new List<string>();
            List<string> agreementsDatabase = System.IO.File.ReadLines(@"..\database\agreement.txt").ToList();

            foreach (string line in agreementsDatabase)
            {
                string temp = line.Substring(line.IndexOf(';')+1);
                resultList.Add(temp.Substring(0, temp.IndexOf(';')));
            }
            return resultList.ToArray();
        }
        private string[] GetContentFromList()
        {
            List<string> resultList = new List<string>();
            List<string> agreementsDatabase = System.IO.File.ReadLines(@"..\database\agreement.txt").ToList();

            foreach (string line in agreementsDatabase)
            {
                string temp = line.Substring(line.IndexOf(';') + 1);
                resultList.Add(temp.Substring(temp.IndexOf(';') + 1));
            }
            return resultList.ToArray();
        }

        public bool AddAgreement(string firstParty, string secondParty, string content)
        {
            if (!CheckIfViable(firstParty, secondParty, content))
                return false;

            System.IO.File.AppendAllText(@"..\database\agreement.txt", firstParty + ";" + secondParty + ";" + content + Environment.NewLine);
            CreateExistingAgreementsToObjects();
            return true;
        }

        public string[] GetAllOfUserAgreements()
        {
            CreateExistingAgreementsToObjects();
            List<string> result = new List<string>();
            foreach (Agreement agreement in agreementsList)
            {
                if (agreement.FirstParty == this.Username)
                {
                    result.Add("To " + agreement.SecondParty + ": " + agreement.Content);
                }
                if (agreement.SecondParty == this.Username)
                {
                    result.Add("From " + agreement.FirstParty + ": " + agreement.Content);
                }
            }
            return result.ToArray();
        }
        public string[] SearchAgreement(string keyword)
        {
            List<string> result = new List<string>();
            List<string> temp = GetAllOfUserAgreements().ToList();
            foreach (string s in temp)
            {
                if (s.Contains(keyword))
                {
                    result.Add(s);
                }
            }
            return result.ToArray();
        }
        public bool UploadComplaint(string complaint, string user)
        {
            if (CheckIfViable(complaint, user))
            {
                System.IO.File.AppendAllText(@"..\database\complaints.txt", user + ";" + complaint + Environment.NewLine);
                return true;
            }
            return false;
        }
        public bool CheckIfViable(string a, string b)
        {
            if (a.Contains(";") || a.Contains("_") || a == "" || b.Contains(";") || b.Contains("_") || a == "")
                return false;

            return true;
        }
        public bool CheckIfViable(string a, string b, string c)
        {
            if (a.Contains(";") || a.Contains("_") || a == "" || b.Contains(";") || b.Contains("_") || b == "" || c.Contains(";") || c.Contains("_") || c == "")
                return false;

            return true;
        }

        private static char Cipher(char ch, int key)
        {
            char d = char.IsUpper(ch) ? 'A' : 'a';
            return (char)((((ch + key) - d) % 26) + d);
        }
        public static string Encipher(string input, int key)
        {
            string output = string.Empty;

            foreach (char ch in input)
            {
                output += Cipher(ch, key);
            }
            return output;
        }
        private static string Decipher(string input, int key)
        {
            return Encipher(input, 26 - key);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentHousing
{
    class Agreement
    {
        private string firstParty;
        private string secondParty;
        private string content;

        public string FirstParty { get; set; }
        public string SecondParty { get; set; }
        public string Content { get; set; }

        public Agreement(string firstParty, string secondParty, string content)
        {
            FirstParty = firstParty;
            SecondParty = secondParty;
            Content = content;
        }
    }
}

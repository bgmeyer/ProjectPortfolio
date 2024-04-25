using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserAccountManager
{
    public class Profile
    {
        public string userName { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }

        public string favoriteTeam { get; set; }

        public string favoritePlayer { get; set; }

       public Profile(string userName, string firstName, string lastName, string favoriteTeam, string favoritePlayer)
        {
            this.userName = userName;
            this.firstName = firstName;
            this.lastName = lastName;
            this.favoriteTeam = favoriteTeam;
            this.favoritePlayer = favoritePlayer; 
        }

    }
}

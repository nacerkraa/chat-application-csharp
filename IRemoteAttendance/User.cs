using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IRemoteAttendance
{
    public class User
    {
        public User(string username, string password, string firstname, string lastname, string address, int numbre_abs) 
        {
            this.username = username;
            this.password = password;
            this.firstname = firstname;
            this.lastname = lastname;
            this.address = address;
            this.numbre_abs = numbre_abs;
        }

        public User()
        {
            
        }
        
        public string username { get; set; }
        public string password { get; set; }
        public string firstname { get; set; }
        public string lastname { get; set; }
        public string address { get; set; }
        public int numbre_abs { get; set; }
        
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLibrary.Models
{
    public class UserModel
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmailAddress { get; set; }
        public string Username { get; set; }
        
        public UserModel(string firstName, string lastName, string emailAddress, string username)
        {
            FirstName = firstName;
            LastName = lastName;
            EmailAddress = emailAddress;
            Username = username;
        }

        public override string ToString()
        {
            return FirstName + " " + LastName;
        }
    }
}

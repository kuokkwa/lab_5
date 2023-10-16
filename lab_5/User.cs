using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace lab_5
{
    public class User
    {
        public string Username { get; set; }
        public string Password {  get; set; }
        public List<Order> PurchaseHistory { get; set; }

        public User(string username, string password)
        {
            Username = username;
            Password = password;
            PurchaseHistory = new List<Order>();
        }
    }
}

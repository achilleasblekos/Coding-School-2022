using App.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Models.Entities
{
    public class Credential : Item
    {
        public string Username { get; set; }
        public string Password { get; set; }

        public Credential(string username)
        {
            Username = username;
            Password = string.Empty;
        }
    }
}

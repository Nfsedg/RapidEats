using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RapidEats.Entities
{
    internal class Usuario
    {
        [Key]
        public int Id { get; set; }
        public string UserName { get; set; }
        private string Password { get; set; }

        public void setPassword(string password)
        {
            this.Password = password;
        }
        public string getPassword()
        {
            return this.Password;
        }
    }
}

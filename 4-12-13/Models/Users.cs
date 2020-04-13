using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _4_12_13.Models
{
    public class Users
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string NickName { get; set; }
        public string Photo { get; set; }
        public DateTime CreateTime { get; set; }
        public int RolesId { get; set; }
    }
}

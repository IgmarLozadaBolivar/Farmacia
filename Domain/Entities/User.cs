using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class User : BaseEntity
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public int IdRolFK {get; set;}
        public Rol Rol { get; set; }
        public ICollection<Farmaceutico> Farmaceuticos {get; set;}
    }
}
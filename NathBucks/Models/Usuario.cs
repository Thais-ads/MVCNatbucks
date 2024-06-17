using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;

namespace NathBucks.Models
{
    public class Usuario
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Email { get; set; }

        public string Password { get; set; }

        public bool IsBlocked { get; set; }

        public virtual ICollection<Role> Roles { get; set; }

    }
}

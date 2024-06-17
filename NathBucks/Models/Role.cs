using System.Collections.Generic;

namespace NathBucks.Models
{
    public class Role
    {
        public int Id { get; set; }

        public string Name { get; set; }

        // Relação muitos-para-muitos com a classe Usuario
        public virtual ICollection<Usuario> Usuarios { get; set; }

    }
}

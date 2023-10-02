using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NathBucks.Models
{
    [Table("Cafeteria")]
    public class Cafeteria
    {
        [Key]
        [Column]
        public int IdCafeteria { get; set; }

        [Column]
        public string Funcionarios{ get; set; }

        [Column]
        public int EstoqueCafe { get; set; }

        [Column]
        public int EstoqueCopos { get; set; }
    }
}

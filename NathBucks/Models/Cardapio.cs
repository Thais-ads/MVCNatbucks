using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NathBucks.Models
{
    [Table("Cardapio")]
    public class Cardapio
    {
        [Key]
        [Column]
        public int IdCardapio { get; set; }

        [Column]
        public string TipoDrink { get; set; }

        [Column]
        public string TamanhoDrink { get; set; }

        [Column]
        public string DescricaoDrink { get; set; }

        [Column]
        public float PrecoDrink { get; set; }
    }
}

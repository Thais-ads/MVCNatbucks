using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NathBucks.Models
{
    [Table("Avaliacao")]
    public class Avaliacao
    {
        [Key]
        [Column]
        public int Id { get; set; }

        [Column]
        public string Nome { get; set; }

        [Column]
        public string Email { get; set; }

        [Column]
        public string Texto { get;set; }

        [Column]
        [Range(1,5)]
        public int Estrelas { get; set; }

        [Column]
        public bool Autorizacao { get; set; }
    }
}

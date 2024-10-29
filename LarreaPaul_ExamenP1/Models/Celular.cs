using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LarreaPaul_ExamenP1.Models
{
    public class Celular
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MinLength(3)]
        public string Modelo { get; set; }
        [MaxLength(4)]

        public int año { get; set; }
        [Range(20, 50000)]
        public float precio { get; set; }
        public PLarrea? cliente { get; set; }
        [ForeignKey("PLarrea")]
        public int IdCliente { get; set; }
    }
}

using System.ComponentModel.DataAnnotations;

namespace LarreaPaul_ExamenP1.Models
{
    public class PLarrea
    {
        [Key]
        [Required]
        public int idNombre { get; set; }
        [EmailAddress]
        public string correo { get; set; }
        [Required]
        [MinLength(9)]
        [Phone]
        public int celular { get; set; }
        [MaxLength(3)]
        public float iq { get; set; }
        [Required]
        public bool casado { get; set; }
        [DataType(DataType.Date)]
        public DateTime FechaCumple { get; set; }



    }
}

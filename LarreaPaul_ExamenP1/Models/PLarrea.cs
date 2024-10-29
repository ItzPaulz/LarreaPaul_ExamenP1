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
        
        
        public int celular { get; set; }
        [Range(1,100000)]
        public float sueldo { get; set; }
        [Required]
        public bool casado { get; set; }
        [DataType(DataType.Date)]
        public DateTime FechaCumple { get; set; }



    }
}

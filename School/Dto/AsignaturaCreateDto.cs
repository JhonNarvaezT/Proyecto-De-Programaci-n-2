using System.ComponentModel.DataAnnotations;

namespace ActaNotasAPI.Models.Dto
{
    public class AsignaturaCreateDto
    {

        
        [Required]
        [MaxLength(50)]
        public string AsignaturaNombre { get; set; }
        [Required]
        [MaxLength(25)]
        public string Semestre { get; set; }
        [Required]
        public int Creditos { get; set; }

    }
}

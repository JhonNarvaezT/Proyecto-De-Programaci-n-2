using System.ComponentModel.DataAnnotations;

namespace SchoolAPI.Models.Dto
{
    public class EstudianteUpdateDto
    {
       
        public int EstudianteId { get; set; }
        [Required]
        [MaxLength(50)]
        public string Nombre { get; set; }

        public int GrupoId { get; set; }
        [Required]
      
        public string Carnet { get; set; }

    }
}

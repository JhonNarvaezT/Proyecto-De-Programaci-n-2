using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SchoolAPI.Models.Dto
{
    public class EstudianteCreateDto
    {

        [Required]
        [MaxLength(50)]
        public string Nombre { get; set; }
       
        [Required]
        public int GrupoId { get; set; }
        [Required]
      
        public string Carnet { get; set; }
    }
}

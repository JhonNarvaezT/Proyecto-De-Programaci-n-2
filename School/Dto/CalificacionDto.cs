using SchoolAPI.Models;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace ActaNotasAPI.Models.Dto
{
    public class CalificacionDto
    {

        public int CalificacionId { get; set; }
        [Required]
        public int EstudianteId { get; set; }
      
        
        [Required]
        public int AsignaturaId { get; set; }
      
     
        public float nota { get; set; }

    }
}

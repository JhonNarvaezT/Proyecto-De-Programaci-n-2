using System.ComponentModel.DataAnnotations;

namespace ActaNotasAPI.Models.Dto
{
    public class GrupoCreateDto
    {

       
        [Required]
        [MaxLength(50)]
        public string Nombre { get; set; }
        [Required]
        public string Año { get; set; }
        [Required]
     
        public string Carnet { get; set; }

    }
}

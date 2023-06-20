using System.ComponentModel.DataAnnotations;

namespace ActaNotasAPI.Models.Dto
{
    public class GrupoUpdateDto
    {

        public int GrupoId { get; set; }
       
        [Required]
        [MaxLength(50)]
        public string Nombre { get; set; }
        [Required]
        public string  Año { get; set; }

    }
}

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SchoolAPI.Models
{
    public class Calificacion
    {

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CalificacionId { get; set; }
        [Required]
        public int EstudianteId { get; set; }
        [ForeignKey("EstudianteId ")]
        public Estudiante Estudiante { get; set; }
        [Required]
        public int AsignaturaId { get; set; }
        [ForeignKey("AsignaturaId  ")]
        public Asignatura Asignatura { get; set; }
        public float nota { get; set; }
    }
}

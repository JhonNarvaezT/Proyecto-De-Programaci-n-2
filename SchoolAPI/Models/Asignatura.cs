using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SchoolAPI.Models
{
    public class Asignatura
    {

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int AsignaturaId { get; set; }
        [Required]
        [StringLength(50)]
        public string AsignaturaNombre { get; set; }
        [Required]
        [StringLength(25)]
        public string Semestre { get; set; }
        [Required]
        public int Creditos { get; set; }

    }
}

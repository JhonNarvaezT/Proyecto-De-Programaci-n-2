using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SchoolAPI.Models
{
    public class Grupo
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int GrupoId { get; set; }
        [Required]
        [StringLength(50)]
        public string Nombre { get; set; }
        [Required]
        public string Año { get; set; }
    }
}

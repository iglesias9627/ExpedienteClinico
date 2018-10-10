using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MedEvolution.Models
{
    public class Examen
    {
        public Examen()
        {
            OrdenExamenes = new HashSet<OrdenExamen>();
        }

        [Key]
        private int codigoExamen { get; set; }

        [Required]
        [StringLength(30)]
        private string tipoMuestra { get; set; }

        [Required]
        [StringLength(30)]
        private string nombreExamen { get; set; }

        public virtual ICollection<OrdenExamen> OrdenExamenes { get; set; }
        
    }
}
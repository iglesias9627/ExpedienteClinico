using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MedEvolution.Models
{
    public class Privilegio
    {
        Privilegio()
        {
            Roles = new HashSet<Rol>();
        }

        [Key]
        private int codigoPrivilegio { get; set; }

        [Required]
        [StringLength(30)]
        private string nombrePrivilegio { get; set; }

        [Required]
        [StringLength(80)]
        private string url { get; set; }

        [Required]
        private bool leer { get; set; }

        [Required]
        private bool borrar { get; set; }

        [Required]
        private bool modificar { get; set; }

        [Required]
        private bool escribir { get; set; }

        public virtual ICollection<Rol> Roles { get; set; }
    }
}
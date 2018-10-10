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
        private int CodigoPrivilegio { get; set; }

        [Required]
        [StringLength(30)]
        private string NombrePrivilegio { get; set; }

        [Required]
        [StringLength(80)]
        private string Url { get; set; }

        [Required]
        private bool Leer { get; set; }

        [Required]
        private bool Borrar { get; set; }

        [Required]
        private bool Modificar { get; set; }

        [Required]
        private bool Escribir { get; set; }

        public virtual ICollection<Rol> Roles { get; set; }
    }
}
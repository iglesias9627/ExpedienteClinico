using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MedEvolution.Models
{
    public class Rol
    {
        Rol()
        {
            Usuarios = new HashSet<Usuario>();
        }

        [Key]
        private string correoLaboral { get; set; }

        [Required]
        [StringLength(30)]
        private string nombreRol { get; set; }

        public virtual ICollection<Usuario> Usuarios { get; set; }
    }
}
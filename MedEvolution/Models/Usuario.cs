using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MedEvolution.Models
{
    public class Usuario
    {
        Usuario()
        {
            Roles = new HashSet<Rol>();
        }

        [Key]
        private string CorreoElectronicoLaboral { get; set; }

        private int CodigoRol { get; set; }

        private int IdEmpleado { get; set; }

        [Required]
        [StringLength(16)]
        private string Contrasenia { get; set; }

        /*Se utilizara cuando se cree una nueva contraseña
         * la nueva contreseña no debe ser igual a la utlima usada*/
        [StringLength(16)]
        private string UltimaContrasenia { get; set; }

        public virtual ICollection<Rol> Roles { get; set; }

        public virtual Rol Rol { get; set; }
        public virtual Empleado Empleadp { get; set; }
    }
}
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
        private string correoElectronicoLaboral { get; set; }

        private int codigoRol { get; set; }

        private int idEmpleado { get; set; }

        [Required]
        [StringLength(16)]
        private string contrasenia { get; set; }

        /*Se utilizara cuando se cree una nueva contraseña
         * la nueva contreseña no debe ser igual a la utlima usada*/
        [StringLength(16)]
        private string ultimaContrasenia { get; set; }

        public virtual ICollection<Rol> Roles { get; set; }

        public virtual Rol Rol { get; set; }
        public virtual Empleado Empleadp { get; set; }
    }
}
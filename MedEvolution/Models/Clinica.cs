using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MedEvolution.Models
{
    public class Clinica
    {
        Clinica()
        {
            Empleados = new HashSet<Empleado>();
        }

        [Key]
        private int idClinica { get; set; }

        private int idEmpleado { get; set; }

        [Required]
        [StringLength(30)]
        private string colonia { get; set; }

        [Required]
        [StringLength(30)]
        private string pasaje_calle { get; set; }

        [Required]
        [StringLength(5)]
        private string casa { get; set; }

        [Required]
        [StringLength(30)]
        private string nombreClinica { get; set; }

        [Required]
        [StringLength(9)]
        private string telefono { get; set; }

        [Required]
        private DateTime fechaApertura { get; set; }

        public virtual ICollection<Empleado> Empleados { get; set; }

        public virtual Direccion Direccion { get; set; }

        public virtual Empleado Director { get; set; }
    }
}
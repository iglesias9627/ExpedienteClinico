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
        private int IdClinica { get; set; }

        private int IdEmpleado { get; set; }

        [Required]
        [StringLength(30)]
        private string Colonia { get; set; }

        [Required]
        [StringLength(30)]
        private string Pasaje_calle { get; set; }

        [Required]
        [StringLength(5)]
        private string Casa { get; set; }

        [Required]
        [StringLength(30)]
        private string NombreClinica { get; set; }

        [Required]
        [StringLength(9)]
        private string Telefono { get; set; }

        [Required]
        private DateTime FechaApertura { get; set; }

        public virtual ICollection<Empleado> Empleados { get; set; }

        public virtual Direccion Direccion { get; set; }

        public virtual Empleado Director { get; set; }
    }
}
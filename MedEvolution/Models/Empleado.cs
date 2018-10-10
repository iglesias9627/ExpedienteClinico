using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MedEvolution.Models
{
    public class Empleado : Persona
    {
        [Key]
        private int idEmpleado { get; set; }

        [StringLength(10)]
        private int dui { get; set; }

        private int idClinica { get; set; }

        private int codigoEstado { get; set; }

        [Required]
        [StringLength(30)]
        private string cargo { get; set; }

        [Required]
        private DateTime fechaContratacion { get; set; }

        private DateTime fechaDespido { get; set; }

        private double salario { get; set; }

        [Required]
        private DateTime horasLaborales { get; set; }

        public virtual Persona Persona { get; set; }

        public virtual Clinica Clinica { get; set; }

        public virtual Estado Estado { get; set; }

    }
}
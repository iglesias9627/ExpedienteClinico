using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MedEvolution.Models
{
    public class Cita
    {
        [Key]
        private int IdCita { get; set; }

        private int Jvpm { get; set; }

        private int IdPaciente { get; set; }

        private int CodigoEstado { get; set; }

        [Required]
        private DateTime FechaCreada { get; set; }

        [Required]
        private DateTime FechaCita { get; set; }

        [Required]
        private DateTime HoraCita { get; set; }

        [Required]
        [StringLength(100)]
        private string Causa { get; set; }

        public virtual Medico Doctor { get; set; }

        public virtual Paciente Paciente { get; set; }

        public virtual Estado Estado { get; set; }
}
}
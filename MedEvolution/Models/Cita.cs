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
        private int idCita { get; set; }

        private int jvpm { get; set; }

        private int idPaciente { get; set; }

        private int codigoEstado { get; set; }

        [Required]
        private DateTime fechaCreada { get; set; }

        [Required]
        private DateTime fechaCita { get; set; }

        [Required]
        private DateTime horaCita { get; set; }

        [Required]
        [StringLength(100)]
        private string causa { get; set; }

        public virtual Medico Doctor { get; set; }

        public virtual Paciente Paciente { get; set; }

        public virtual Estado Estado { get; set; }
}
}
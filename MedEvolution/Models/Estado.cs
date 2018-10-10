using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MedEvolution.Models
{
    public class Estado
    {
        Estado()
        {
            Citas = new HashSet<Cita>();
            Pacientes = new HashSet<Paciente>();
        }

        [Key]
        private int codigoEstado { get; set; }

        [Required]
        [StringLength(20)]
        private string nombreEstado { get; set; }

        public virtual ICollection<Cita> Citas { get; set; }
        public virtual ICollection<Paciente> Pacientes { get; set; }
    }
}
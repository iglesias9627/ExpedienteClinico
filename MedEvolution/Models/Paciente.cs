using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MedEvolution.Models
{
    public class Paciente: Persona
    {
        Paciente()
        {
            Citas = new HashSet<Cita>();
        }

        [Key]
        private int idPaciente { get; set; }

        private int codigoEstado { get; set; }

        [StringLength(10)]
        public string dui { get; set; }

        [Required]
        private DateTime fechaCreacion { get; set; }

        private DateTime fechaDeBaja { get; set; }

        public virtual ICollection<Cita> Citas { get; set; }

        public virtual Estado Estado { get; set; }

        public virtual Persona Persona { get; set; }

    }
}
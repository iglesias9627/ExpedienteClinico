using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MedEvolution.Models
{
    public class Especialidad_Desempeniada
    {
        Especialidad_Desempeniada()
        {
            Medicos = new HashSet<Medico>();
        }

        [Key]
        private int codigoEspecialidad { get; set; }

        [Required]
        [StringLength(30)]
        private string nombreEspecialidad { get; set; }

        public virtual ICollection<Medico> Medicos { get; set; }
    }
}
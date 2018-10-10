using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MedEvolution.Models
{
    public class Horario_De_Atencion
    {
        Horario_De_Atencion()
        {
            Medicos = new HashSet<Medico>();
        }

        [Key]
        private int codigoHorario { get; set; }

        [Required]
        private DateTime horaInicio { get; set; }

        [Required]
        private DateTime horaFin { get; set; }

        [Required]
        private int numeroCitasAtender { get; set; }

        public virtual ICollection<Medico> Medicos { get; set; }
    }
}
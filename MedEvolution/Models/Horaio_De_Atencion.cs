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
        private int CodigoHorario { get; set; }

        [Required]
        private DateTime HoraInicio { get; set; }

        [Required]
        private DateTime HoraFin { get; set; }

        [Required]
        private int NumeroCitasAtender { get; set; }

        public virtual ICollection<Medico> Medicos { get; set; }
    }
}
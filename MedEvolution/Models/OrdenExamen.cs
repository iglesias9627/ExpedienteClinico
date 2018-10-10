using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MedEvolution.Models
{
    public class OrdenExamen
    {
        [Key]
        private int IdOrden { get; set; }

        private int IdConsulta { get; set; }

        private int CodigoExamen { get; set; }

        [Required]
        private bool Urgencia { get; set; }

        private byte Resultado { get; set; }

        private DateTime FechaResultado { get; set; }

        public virtual Consulta Consulta { get; set; }

        public virtual Examen Examen { get; set; }
    }
}
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
        private int idOrden { get; set; }

        private int idConsulta { get; set; }

        private int codigoExamen { get; set; }

        [Required]
        private bool urgencia { get; set; }

        private byte resultado { get; set; }

        private DateTime fechaResultado { get; set; }

        public virtual Consulta Consulta { get; set; }

        public virtual Examen Examen { get; set; }
    }
}
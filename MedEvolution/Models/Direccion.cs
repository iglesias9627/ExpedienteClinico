using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MedEvolution.Models
{
    public class Direccion
    {
        public Direccion()
        {
            Personas = new HashSet<Persona>();
            Clinicas = new HashSet<Clinica>();
        }

        [Key]
        [Column(Order = 0)]
        [StringLength(30)]
        private string colonia { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(30)]
        private string pasaje_calle { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(5)]
        private string casa { get; set; }

        private int codigoMunicipio { get; set; }

        [Required]
        [StringLength(50)]
        private string detalle { get; set; }

        public virtual Municipio Municipio { get; set; }

        public virtual ICollection<Clinica> Clinicas { get; set; }

        public virtual ICollection<Persona> Personas { get; set; }
    }
}
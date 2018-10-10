using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MedEvolution.Models
{
    public class Municipio
    {
        public Municipio()
        {
            Direcciones = new HashSet<Direccion>();
        }

        [Key]
        private int CodigoMunicipio { get; set; }

        private int CodigoDepartamento { get; set; }

        [Required]
        [StringLength(30)]
        private string NombreMun { get; set; }
          
        public virtual Departamento Departamento { get; set; }

        public ICollection<Direccion> Direcciones { get; set; }
    }
}
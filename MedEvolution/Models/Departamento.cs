using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MedEvolution.Models
{
    public class Departamento
    {
        public Departamento()
        {
            Municipios = new HashSet<Municipio>();
        }

        [Key]
        private int CodigoDepartamento { get; set; }

        [Required]
        [StringLength(30)]
        private string NombreDep { get; set; }

        public virtual ICollection<Municipio> Municipios { get; set; }
    }
}
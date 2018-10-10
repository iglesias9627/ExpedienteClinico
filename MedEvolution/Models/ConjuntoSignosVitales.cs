
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Data.Entity.Spatial;

namespace MedEvolution.Models
{
    public class ConjuntoSignosVitales
    {
        public ConjuntoSignosVitales()
        {
            Consultas = new HashSet<Consulta>();
        }

        [Key]
        public int idSignos { get; set; }

        [Required]
        public decimal presionArterial { get; set; }

        [Required]
        public decimal teperatura { get; set; }

        [Required]
        public decimal peso { get; set; }

        [Required]
        public decimal pulsoCardiaco { get; set; }

        [Required]
        public decimal estatura { get; set; }

        public virtual ICollection<Consulta> Consultas { get; set; }
    }
}
    


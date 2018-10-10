using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MedEvolution.Models
{
    public class Medicamento
    {
        public Medicamento()
        {
            Recetas = new HashSet<Receta>();
        }

        [Key]
        private int CodigoMedicamento { get; set; }

        [Required]
        [StringLength(20)]
        private string NombreMed { get; set; }

        public virtual ICollection<Receta> Recetas { get; set; }

    }
}
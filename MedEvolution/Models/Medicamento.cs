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
        private int codigoMedicamento { get; set; }

        [Required]
        [StringLength(20)]
        private string nombreMed { get; set; }

        public virtual ICollection<Receta> Recetas { get; set; }

    }
}
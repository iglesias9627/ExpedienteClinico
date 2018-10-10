using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MedEvolution.Models
{
    public class Consulta
    {
        Consulta()
        {
            Recetas = new HashSet<Receta>();
            OrdenesExamen = new HashSet<OrdenExamen>();
        }

        [Key]
        private int idConsulta { get; set; }

        private int idCita { get; set; }

        private int idSignos { get; set; }

        [Required]
        [StringLength(254)]
        private string sintomatología { get; set; }

        [Required]
        [StringLength(254)]
        private string diagnostico { get; set; }

        [Required]
        [StringLength(254)]
        private string tratamiento { get; set; }

        [Required]
        private DateTime horaConsulta { get; set; }

        [Required]
        [StringLength(254)]
        private string procedimientoEnfermera { get; set; }

        public virtual ICollection<Receta> Recetas  { get; set; }

        public virtual ICollection<OrdenExamen> OrdenesExamen { get; set; }

        public virtual Cita Cita { get; set; }

        public virtual ConjuntoSignosVitales Signos { get; set; }
    }
}
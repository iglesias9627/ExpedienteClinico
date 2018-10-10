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
        private int IdConsulta { get; set; }

        private int IdCita { get; set; }

        private int IdSignos { get; set; }

        [Required]
        [StringLength(254)]
        private string Sintomatología { get; set; }

        [Required]
        [StringLength(254)]
        private string Diagnostico { get; set; }

        [Required]
        [StringLength(254)]
        private string Tratamiento { get; set; }

        [Required]
        private DateTime HoraConsulta { get; set; }

        [Required]
        [StringLength(254)]
        private string ProcedimientoEnfermera { get; set; }

        public virtual ICollection<Receta> Recetas  { get; set; }

        public virtual ICollection<OrdenExamen> OrdenesExamen { get; set; }

        public virtual Cita Cita { get; set; }

        public virtual ConjuntoSignosVitales Signos { get; set; }
    }
}
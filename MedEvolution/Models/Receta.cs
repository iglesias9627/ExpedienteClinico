    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Data.Entity.Spatial;

    namespace MedEvolution.Models
    {
        public partial class Receta
        {
            [Key]
            public int IdReceta { get; set; }

            public int CodigoMedicamento { get; set; }

            public int? IdConsulta { get; set; }

            [Required]
            [StringLength(254)]
            public string Instrucciones { get; set; }

            public virtual Consulta Consulta { get; set; }

            public virtual Medicamento Medicamento { get; set; }
        }
    }
    

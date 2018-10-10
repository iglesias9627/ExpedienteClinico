    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Data.Entity.Spatial;

    namespace MedEvolution.Models
    {
        public partial class Receta
        {
            [Key]
            public int idReceta { get; set; }

            public int codigoMedicamento { get; set; }

            public int? idConsulta { get; set; }

            [Required]
            [StringLength(254)]
            public string instrucciones { get; set; }

            public virtual Consulta Consulta { get; set; }

            public virtual Medicamento Medicamento { get; set; }
        }
    }
    

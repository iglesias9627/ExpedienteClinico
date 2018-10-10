using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MedEvolution.Models
{
    public abstract class Persona
    {
        [Key]
        [StringLength(10)]
        private string dui { get; set; }

        [Required]
        [StringLength(30)]
        private string colonia { get; set; }

        [Required]
        [StringLength(30)]
        private string pasaje_calle { get; set; }

        [Required]
        [StringLength(5)]
        private string casa { get; set; }

        [Required]
        [StringLength(15)]
        private string nombre1 { get; set; }

        [StringLength(15)]
        private string nombre2 { get; set; }

        [Required]
        [StringLength(15)]
        private string apellido1 { get; set; }

        [StringLength(15)]
        private string apellido2 { get; set; }

        [Required]
        [StringLength(9)]
        private string telefono { get; set; }

        [Required]
        [StringLength(9)]
        private string celular { get; set; }

        [StringLength(10)]
        private string tipoSangre { get; set; }

        [Required]
        private DateTime fechaNac { get; set; }

        [Required]
        [StringLength(10)]
        private string sexo { get; set; }

        [Required]
        [StringLength(30)]
        private string ocupacion { get; set; }

        [Required]
        [StringLength(30)]
        private string correoElectronico { get; set; }

        [Required]
        [StringLength(50)]
        private string alergia { get; set; }

        private bool discapacidad { get; set; }

        [StringLength(254)]
        private string tipoDiscapacidad { get; set; }

        [StringLength(15)]
        private string nombreMadre { get; set; }

        [StringLength(15)]
        private string apellidoMadre { get; set; }

        [StringLength(15)]
        private string nombrePadre { get; set; }

        [StringLength(15)]
        private string apellidoPadre { get; set; }

        [Required]
        [StringLength(20)]
        private string estadoCivil { get; set; }

        [StringLength(15)]
        private string nombreConyugue { get; set; }

        [StringLength(15)]
        private string apellidoConyugue { get; set; }

        [Required]
        [StringLength(15)]
        private string nombreContactoEmergencia { get; set; }

        [Required]
        [StringLength(15)]
        private string apellidoContactoEmergencia { get; set; }

        [Required]
        [StringLength(9)]
        private string telefonoContactoEmergencia { get; set; }

        [Required]
        [StringLength(9)]
        private string celularContactoEmergencia { get; set; }

        public virtual Direccion Direccion { get; set; }

    }
}
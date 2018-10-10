using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MedEvolution.Models
{
    public class Medico: Empleado
    {
        public Medico()
        {
            Citas = new HashSet<Cita>();
        }

        [Key]
        private int Jvpm { get; set; }

        private int CodigoEspecialidad { get; set; }

        private int CodigoHorario { get; set; }

        private int IdEmpleado { get; set; }

        public virtual ICollection<Cita> Citas { get; set; }

        public virtual Empleado Empleado { get; set; }

        public virtual Especialidad_Desempeniada Especialidad_Desempeniada { get; set; }

        public virtual Horario_De_Atencion Horarios_De_Atencion { get; set; }
    }
}
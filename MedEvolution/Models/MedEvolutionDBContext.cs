using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MedEvolution.Models
{
    public class MedEvolutionDbContext: DbContext
    {
        public DbSet<Departamento> Departamento { get; set; }
        public DbSet<Municipio> Municipio { get; set; }
        public DbSet<Direccion> Direccion { get; set; }
        public DbSet<Medicamento> Medicamento { get; set; }
        public DbSet<Persona> Persona { get; set; }
        public DbSet<Paciente> Paciente  { get; set; }
        public DbSet<Empleado> Empleado  { get; set; }
        public DbSet<Medico> Medico  { get; set; }
        public DbSet<Examen> Examen { get; set; }
        public DbSet<Privilegio> Privilegio { get; set; }
        public DbSet<Menu> Menu { get; set; }
        public DbSet<Estado> Estado { get; set; }
        public DbSet<ConjuntoSignosVitales> ConjuntoSignosVitales { get; set; }
        public DbSet<Especialidad_Desempeniada> Especialidad_Desempeniada { get; set; }
        public DbSet<Horario_De_Atencion> Horario_De_Atencion { get; set; }
        public DbSet<Clinica> Clinica { get; set; }
        public DbSet<Cita> Cita { get; set; }
        public DbSet<Consulta> Consulta { get; set; }
        public DbSet<OrdenExamen> OrdenExamen { get; set; }
        public DbSet<Receta> Receta { get; set; }
        public DbSet<Rol> Rol { get; set; }
        public DbSet<Usuario> Usuario { get; set; }


    }
}
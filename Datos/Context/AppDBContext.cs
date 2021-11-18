using ProyectoFinalPooJA.Datos.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using ProyectoFinalPooJA.Datos.Mapping;

namespace ProyectoFinalPooJA.Datos.Context
{
    public class AppDBContext : DbContext 
    {
        public AppDBContext() : base("name=mssql") { }

        public DbSet<Cargo> Cargos { get; set; }
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Color> Colors { get; set; }
        public DbSet<Departamento> Departamentos { get; set; }
        public DbSet<Empleado> Empleados { get; set; }
        public DbSet<Entrega> Entregas { get; set; }
        public DbSet<Incidencia> Incidencias { get; set; }
        public DbSet<Marca> Marcas { get; set; }
        public DbSet<Modelo> Modelos { get; set; }
        public DbSet<Prioridad> Prioridades { get; set; }
        public DbSet<Taller> Talleres { get; set; }
        public DbSet<Tipo_Vehiculo> Tipo_Vehiculos { get; set; }
        public DbSet<Vehiculo> Vehiculos { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new CargoMap());
            modelBuilder.Configurations.Add(new ClienteMap());
            modelBuilder.Configurations.Add(new ColorMap());
            modelBuilder.Configurations.Add(new DepartamentoMap());
            modelBuilder.Configurations.Add(new EmpleadoMap());
            modelBuilder.Configurations.Add(new EntregaMap());
            modelBuilder.Configurations.Add(new IncidenciaMap());
            modelBuilder.Configurations.Add(new MarcaMap());
            modelBuilder.Configurations.Add(new ModeloMap());
            modelBuilder.Configurations.Add(new PrioridadMap());
            modelBuilder.Configurations.Add(new TallerMap());
            modelBuilder.Configurations.Add(new Tipo_VehiculoMap());
            modelBuilder.Configurations.Add(new VehiculoMap());

            base.OnModelCreating(modelBuilder);
        }

    }
}

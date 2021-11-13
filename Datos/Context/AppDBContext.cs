using ProyectoFinalPooJA.Datos.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinalPooJA.Datos.Context
{
    public class AppDBContext : DbContext
    {
        public AppDBContext() : base("name=mssql") { }

        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Color> Colors { get; set; }
        public DbSet<Empleado> Empleados { get; set; }
        public DbSet<Entrega> Entregas { get; set; }
        public DbSet<Incidencia> Incidencias { get; set; }
        public DbSet<Marca> Marcas { get; set; }
        public DbSet<Modelo> Modelos { get; set; }
        public DbSet<Prioridad> Prioridades { get; set; }
        public DbSet<Taller> Tallers { get; set; }
        public DbSet<Tipo_Vehiculo> Tipo_Vehiculos { get; set; }
        public DbSet<Vehiculo> Vehiculos { get; set; }

    }
}

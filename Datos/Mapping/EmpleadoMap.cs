using ProyectoFinalPooJA.Datos.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinalPooJA.Datos.Mapping
{
    public class EmpleadoMap: EntityTypeConfiguration<Empleado>
    {
        public EmpleadoMap()
        {
            this.ToTable("Empleado");

            //Primary key
            this.HasKey(c => c.ID);

            //Properties
            this.Property(c => c.ID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity)
                .IsRequired();

            this.Property(c => c.Nombre)
                .IsRequired()
                .HasColumnType("varchar")
                .HasMaxLength(100);

            this.Property(c => c.Cedula)
                .IsRequired()
                .HasColumnType("varchar")
                .HasMaxLength(11);

            this.Property(c => c.Correo)
                .IsRequired()
                .HasColumnType("varchar")
                .HasMaxLength(50);
            
            this.Property(c => c.Telefono)
                .IsRequired()
                .HasColumnType("varchar")
                .HasMaxLength(15);

            this.Property(c => c.Codigo_Empleado)
               .IsRequired();

            //Foreign key
            this.HasRequired(c => c.Cargo)
                .WithMany(c => c.Empleados)
                .HasForeignKey(c => c.CargoID);

            //Foreign key
            this.HasRequired(c => c.Departamento)
                .WithMany(c => c.Empleados)
                .HasForeignKey(c => c.DepartamentoID);

            this.Property(c => c.Fecha_Nacimiento)
                .IsRequired()
                .HasColumnType("datetime");

            this.Property(c => c.Fecha_Ingreso)
                .IsRequired()
                .HasColumnType("datetime");

            this.Ignore(c => c.Edad);

            this.Property(c => c.Estatus)
               .HasColumnType("varchar")
               .HasMaxLength(1);

            this.Property(c => c.Borrado)
                .HasColumnType("bit");

            this.Property(c => c.Fecha_Registro)
                .HasColumnType("datetime");

            this.Property(c => c.Fecha_Modificacion)
                .HasColumnType("datetime");

        }

    }
}

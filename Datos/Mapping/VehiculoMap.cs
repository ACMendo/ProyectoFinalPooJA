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
    public class VehiculoMap: EntityTypeConfiguration<Vehiculo>
    {
        public VehiculoMap()
        {
            this.ToTable("Vehiculo");

            //Primary key
            this.HasKey(c => c.ID);

            //Properties
            this.Property(c => c.ID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity)
                .IsRequired();

            this.Property(c => c.Chasis)
                .IsRequired()
                .HasColumnType("varchar")
                .HasMaxLength(20);

            this.Property(c => c.Placa)
                .IsRequired()
                .HasColumnType("varchar")
                .HasMaxLength(20);

            this.Property(c => c.Transmision)
                .IsRequired()
                .HasColumnType("varchar")
                .HasMaxLength(100);

            this.Property(c => c.Combustible)
                .IsRequired()
                .HasColumnType("varchar")
                .HasMaxLength(100);

            this.Property(c => c.Mantenimiento)
                .HasColumnType("bit");

            this.Property(c => c.Anio)
                .IsRequired()
                .HasColumnType("varchar")
                .HasMaxLength(4);

            //Foreign key
            this.HasRequired(c => c.Modelo)
                .WithMany(c => c.Vehiculos)
                .HasForeignKey(c => c.ModeloID);

            //Foreign key
            this.HasRequired(c => c.Color)
                .WithMany(c => c.Vehiculos)
                .HasForeignKey(c => c.ColorID);

            //Foreign key
            this.HasRequired(c => c.Empleado)
                .WithMany(c => c.Vehiculos)
                .HasForeignKey(c => c.EmpleadoID);

            //Foreign key
            this.HasRequired(c => c.Tipo_Vehiculo)
                .WithMany(c => c.Vehiculos)
                .HasForeignKey(c => c.Tipo_VehiculoID);

            this.Property(c => c.Estatus)
                .HasColumnType("varchar")
                .HasMaxLength(1);

            this.Property(c => c.Borrado)
               .HasColumnType("bit");

            this.Property(c => c.Fecha_Registro)
                .HasColumnType("datetime");

            this.Property(c => c.Fecha_Modificacion)
                .HasColumnType("datetime")
                .IsOptional();

        }

    }
}

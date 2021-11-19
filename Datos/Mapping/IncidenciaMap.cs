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
    public class IncidenciaMap: EntityTypeConfiguration<Incidencia>
    {
        public IncidenciaMap()
        {
            this.ToTable("Incidencia");

            //Primary key
            this.HasKey(c => c.ID);

            //Properties
            this.Property(c => c.ID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity)
                .IsRequired();

            this.Property(c => c.Descripcion)
                .IsRequired()
                .HasColumnType("nvarchar(max)");

            this.Property(c => c.Fecha_Entrada)
                .HasColumnType("datetime");

            this.Property(c => c.Fecha_Salida)
                .HasColumnType("datetime");

            //Foreign key
            this.HasRequired(c => c.Taller)
                .WithMany(c => c.Incidencias)
                .HasForeignKey(c => c.TallerID);

            //Foreign key
            this.HasRequired(c => c.Vehiculo)
                .WithMany(c => c.Incidencias)
                .HasForeignKey(c => c.VehiculoID);

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

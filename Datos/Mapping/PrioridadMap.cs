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
    public class PrioridadMap: EntityTypeConfiguration<Prioridad>
    {
        public PrioridadMap()
        {
            this.ToTable("Prioridad");

            //Primary key
            this.HasKey(c => c.ID);

            //Properties
            this.Property(c => c.ID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity)
                .IsRequired();

            this.Property(c => c.Nombre)
                .IsRequired()
                .HasColumnType("varchar")
                .HasMaxLength(50);

            this.Property(c => c.Horas)
                .IsRequired();

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

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
    public class TallerMap: EntityTypeConfiguration<Taller>
    {
        public TallerMap()
        {
            this.ToTable("Taller");

            //Primary key
            this.HasKey(c => c.ID);

            //Properties
            this.Property(c => c.ID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity)
                .IsRequired();

            this.Property(c => c.Nombre)
                .IsRequired()
                .HasColumnType("varchar")
                .HasMaxLength(150);

            this.Property(c => c.Direccion)
                .IsRequired()
                .HasColumnType("nvarchar(max)");

            this.Property(c => c.Telefono)
               .IsRequired()
               .HasColumnType("varchar")
               .HasMaxLength(15);

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

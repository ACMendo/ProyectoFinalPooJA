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
    public class EntregaMap: EntityTypeConfiguration<Entrega>
    {
        public EntregaMap()
        {
            this.ToTable("Entrega");

            //Primary key
            this.HasKey(c => c.ID);

            //Properties
            this.Property(c => c.ID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity)
                .IsRequired();

            this.Property(c => c.Destino)
                .IsRequired()
                .HasColumnType("nvarchar(max)");

            this.Property(c => c.Fecha_Salida)
                .IsRequired()
                .HasColumnType("datetime");

            this.Property(c => c.Fecha_Regreso)
                .IsRequired()
                .HasColumnType("datetime");

            this.Property(c => c.Descripcion)
                .IsRequired()
                .HasColumnType("nvarchar(max)");

            this.Property(c => c.Peso)
                .IsRequired()
                .HasColumnType("decimal");
               
            //Foreign key
            this.HasRequired(c => c.Empleado)
                .WithMany(c => c.Entregas)
                .HasForeignKey(c => c.EmpleadoID);

            //Foreign key
            this.HasRequired(c => c.Cliente)
                .WithMany(c => c.Entregas)
                .HasForeignKey(c => c.ClienteID);

            //Foreign key
            this.HasRequired(c => c.Prioridad)
                .WithMany(c => c.Entregas)
                .HasForeignKey(c => c.PrioridadID);

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

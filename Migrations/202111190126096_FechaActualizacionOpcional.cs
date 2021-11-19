namespace ProyectoFinalPooJA.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class FechaActualizacionOpcional : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Cargo", "Fecha_Modificacion", c => c.DateTime());
            AlterColumn("dbo.Empleado", "Fecha_Modificacion", c => c.DateTime());
            AlterColumn("dbo.Departamento", "Fecha_Modificacion", c => c.DateTime());
            AlterColumn("dbo.Entrega", "Fecha_Modificacion", c => c.DateTime());
            AlterColumn("dbo.Cliente", "Fecha_Modificacion", c => c.DateTime());
            AlterColumn("dbo.Prioridad", "Fecha_Modificacion", c => c.DateTime());
            AlterColumn("dbo.Vehiculo", "Fecha_Modificacion", c => c.DateTime());
            AlterColumn("dbo.Color", "Fecha_Modificacion", c => c.DateTime());
            AlterColumn("dbo.Incidencia", "Fecha_Modificacion", c => c.DateTime());
            AlterColumn("dbo.Taller", "Fecha_Modificacion", c => c.DateTime());
            AlterColumn("dbo.Modelo", "Fecha_Modificacion", c => c.DateTime());
            AlterColumn("dbo.Marca", "Fecha_Modificacion", c => c.DateTime());
            AlterColumn("dbo.Tipo_Vehiculo", "Fecha_Modificacion", c => c.DateTime());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Tipo_Vehiculo", "Fecha_Modificacion", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Marca", "Fecha_Modificacion", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Modelo", "Fecha_Modificacion", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Taller", "Fecha_Modificacion", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Incidencia", "Fecha_Modificacion", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Color", "Fecha_Modificacion", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Vehiculo", "Fecha_Modificacion", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Prioridad", "Fecha_Modificacion", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Cliente", "Fecha_Modificacion", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Entrega", "Fecha_Modificacion", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Departamento", "Fecha_Modificacion", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Empleado", "Fecha_Modificacion", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Cargo", "Fecha_Modificacion", c => c.DateTime(nullable: false));
        }
    }
}

namespace ProyectoFinalPooJA.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Cargo",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Nombre = c.String(nullable: false, maxLength: 100, unicode: false),
                        Estatus = c.String(maxLength: 1, unicode: false),
                        Borrado = c.Boolean(nullable: false),
                        Fecha_Registro = c.DateTime(nullable: false),
                        Fecha_Modificacion = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Empleado",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Nombre = c.String(nullable: false, maxLength: 100, unicode: false),
                        Cedula = c.String(nullable: false, maxLength: 11, unicode: false),
                        Correo = c.String(nullable: false, maxLength: 50, unicode: false),
                        Telefono = c.String(nullable: false, maxLength: 15, unicode: false),
                        Codigo_Empleado = c.Int(nullable: false),
                        CargoID = c.Int(nullable: false),
                        DepartamentoID = c.Int(nullable: false),
                        Fecha_Ingreso = c.DateTime(nullable: false),
                        Fecha_Nacimiento = c.DateTime(nullable: false),
                        Estatus = c.String(maxLength: 1, unicode: false),
                        Borrado = c.Boolean(nullable: false),
                        Fecha_Registro = c.DateTime(nullable: false),
                        Fecha_Modificacion = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Cargo", t => t.CargoID, cascadeDelete: true)
                .ForeignKey("dbo.Departamento", t => t.DepartamentoID, cascadeDelete: true)
                .Index(t => t.CargoID)
                .Index(t => t.DepartamentoID);
            
            CreateTable(
                "dbo.Departamento",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Nombre = c.String(nullable: false, maxLength: 150, unicode: false),
                        Estatus = c.String(maxLength: 1, unicode: false),
                        Borrado = c.Boolean(nullable: false),
                        Fecha_Registro = c.DateTime(nullable: false),
                        Fecha_Modificacion = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Entrega",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Destino = c.String(nullable: false),
                        Fecha_Salida = c.DateTime(nullable: false),
                        Fecha_Regreso = c.DateTime(nullable: false),
                        Descripcion = c.String(nullable: false),
                        Peso = c.Decimal(nullable: false, precision: 18, scale: 2),
                        EmpleadoID = c.Int(nullable: false),
                        ClienteID = c.Int(nullable: false),
                        PrioridadID = c.Int(nullable: false),
                        Estatus = c.String(maxLength: 1, unicode: false),
                        Borrado = c.Boolean(nullable: false),
                        Fecha_Registro = c.DateTime(nullable: false),
                        Fecha_Modificacion = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Cliente", t => t.ClienteID, cascadeDelete: true)
                .ForeignKey("dbo.Empleado", t => t.EmpleadoID, cascadeDelete: true)
                .ForeignKey("dbo.Prioridad", t => t.PrioridadID, cascadeDelete: true)
                .Index(t => t.EmpleadoID)
                .Index(t => t.ClienteID)
                .Index(t => t.PrioridadID);
            
            CreateTable(
                "dbo.Cliente",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Nombre = c.String(nullable: false, maxLength: 100, unicode: false),
                        Direccion = c.String(nullable: false, maxLength: 500, unicode: false),
                        Correo = c.String(nullable: false, maxLength: 50, unicode: false),
                        Telefono = c.String(nullable: false, maxLength: 15, unicode: false),
                        Identificacion = c.String(nullable: false, maxLength: 13, unicode: false),
                        Tipo_Identificacion = c.String(nullable: false, maxLength: 6, unicode: false),
                        Estatus = c.String(maxLength: 1, unicode: false),
                        Borrado = c.Boolean(nullable: false),
                        Fecha_Registro = c.DateTime(nullable: false),
                        Fecha_Modificacion = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Prioridad",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Nombre = c.String(nullable: false, maxLength: 50, unicode: false),
                        Horas = c.Int(nullable: false),
                        Estatus = c.String(maxLength: 1, unicode: false),
                        Borrado = c.Boolean(nullable: false),
                        Fecha_Registro = c.DateTime(nullable: false),
                        Fecha_Modificacion = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Vehiculo",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Chasis = c.String(nullable: false, maxLength: 20, unicode: false),
                        Placa = c.String(nullable: false, maxLength: 20, unicode: false),
                        Transmision = c.String(nullable: false, maxLength: 100, unicode: false),
                        Combustible = c.String(nullable: false, maxLength: 100, unicode: false),
                        Mantenimiento = c.Boolean(nullable: false),
                        Anio = c.String(nullable: false, maxLength: 4, unicode: false),
                        ModeloID = c.Int(nullable: false),
                        ColorID = c.Int(nullable: false),
                        EmpleadoID = c.Int(nullable: false),
                        Tipo_VehiculoID = c.Int(nullable: false),
                        Estatus = c.String(maxLength: 1, unicode: false),
                        Borrado = c.Boolean(nullable: false),
                        Fecha_Registro = c.DateTime(nullable: false),
                        Fecha_Modificacion = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Color", t => t.ColorID, cascadeDelete: true)
                .ForeignKey("dbo.Empleado", t => t.EmpleadoID, cascadeDelete: true)
                .ForeignKey("dbo.Modelo", t => t.ModeloID, cascadeDelete: true)
                .ForeignKey("dbo.Tipo_Vehiculo", t => t.Tipo_VehiculoID, cascadeDelete: true)
                .Index(t => t.ModeloID)
                .Index(t => t.ColorID)
                .Index(t => t.EmpleadoID)
                .Index(t => t.Tipo_VehiculoID);
            
            CreateTable(
                "dbo.Color",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Nombre = c.String(nullable: false, maxLength: 100, unicode: false),
                        Estatus = c.String(maxLength: 1, unicode: false),
                        Borrado = c.Boolean(nullable: false),
                        Fecha_Registro = c.DateTime(nullable: false),
                        Fecha_Modificacion = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Incidencia",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Descripcion = c.String(nullable: false),
                        Fecha_Entrada = c.DateTime(nullable: false),
                        Fecha_Salida = c.DateTime(nullable: false),
                        TallerID = c.Int(nullable: false),
                        VehiculoID = c.Int(nullable: false),
                        Estatus = c.String(maxLength: 1, unicode: false),
                        Borrado = c.Boolean(nullable: false),
                        Fecha_Registro = c.DateTime(nullable: false),
                        Fecha_Modificacion = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Taller", t => t.TallerID, cascadeDelete: true)
                .ForeignKey("dbo.Vehiculo", t => t.VehiculoID, cascadeDelete: true)
                .Index(t => t.TallerID)
                .Index(t => t.VehiculoID);
            
            CreateTable(
                "dbo.Taller",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Nombre = c.String(nullable: false, maxLength: 150, unicode: false),
                        Direccion = c.String(nullable: false),
                        Telefono = c.String(nullable: false, maxLength: 15, unicode: false),
                        Estatus = c.String(maxLength: 1, unicode: false),
                        Borrado = c.Boolean(nullable: false),
                        Fecha_Registro = c.DateTime(nullable: false),
                        Fecha_Modificacion = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Modelo",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Nombre = c.String(nullable: false, maxLength: 100, unicode: false),
                        MarcaID = c.Int(nullable: false),
                        Estatus = c.String(maxLength: 1, unicode: false),
                        Borrado = c.Boolean(nullable: false),
                        Fecha_Registro = c.DateTime(nullable: false),
                        Fecha_Modificacion = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Marca", t => t.MarcaID, cascadeDelete: true)
                .Index(t => t.MarcaID);
            
            CreateTable(
                "dbo.Marca",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Nombre = c.String(nullable: false, maxLength: 100, unicode: false),
                        Estatus = c.String(maxLength: 1, unicode: false),
                        Borrado = c.Boolean(nullable: false),
                        Fecha_Registro = c.DateTime(nullable: false),
                        Fecha_Modificacion = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Tipo_Vehiculo",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Nombre = c.String(nullable: false, maxLength: 150, unicode: false),
                        Descripcion = c.String(nullable: false),
                        Estatus = c.String(maxLength: 1, unicode: false),
                        Borrado = c.Boolean(nullable: false),
                        Fecha_Registro = c.DateTime(nullable: false),
                        Fecha_Modificacion = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Vehiculo", "Tipo_VehiculoID", "dbo.Tipo_Vehiculo");
            DropForeignKey("dbo.Vehiculo", "ModeloID", "dbo.Modelo");
            DropForeignKey("dbo.Modelo", "MarcaID", "dbo.Marca");
            DropForeignKey("dbo.Incidencia", "VehiculoID", "dbo.Vehiculo");
            DropForeignKey("dbo.Incidencia", "TallerID", "dbo.Taller");
            DropForeignKey("dbo.Vehiculo", "EmpleadoID", "dbo.Empleado");
            DropForeignKey("dbo.Vehiculo", "ColorID", "dbo.Color");
            DropForeignKey("dbo.Entrega", "PrioridadID", "dbo.Prioridad");
            DropForeignKey("dbo.Entrega", "EmpleadoID", "dbo.Empleado");
            DropForeignKey("dbo.Entrega", "ClienteID", "dbo.Cliente");
            DropForeignKey("dbo.Empleado", "DepartamentoID", "dbo.Departamento");
            DropForeignKey("dbo.Empleado", "CargoID", "dbo.Cargo");
            DropIndex("dbo.Modelo", new[] { "MarcaID" });
            DropIndex("dbo.Incidencia", new[] { "VehiculoID" });
            DropIndex("dbo.Incidencia", new[] { "TallerID" });
            DropIndex("dbo.Vehiculo", new[] { "Tipo_VehiculoID" });
            DropIndex("dbo.Vehiculo", new[] { "EmpleadoID" });
            DropIndex("dbo.Vehiculo", new[] { "ColorID" });
            DropIndex("dbo.Vehiculo", new[] { "ModeloID" });
            DropIndex("dbo.Entrega", new[] { "PrioridadID" });
            DropIndex("dbo.Entrega", new[] { "ClienteID" });
            DropIndex("dbo.Entrega", new[] { "EmpleadoID" });
            DropIndex("dbo.Empleado", new[] { "DepartamentoID" });
            DropIndex("dbo.Empleado", new[] { "CargoID" });
            DropTable("dbo.Tipo_Vehiculo");
            DropTable("dbo.Marca");
            DropTable("dbo.Modelo");
            DropTable("dbo.Taller");
            DropTable("dbo.Incidencia");
            DropTable("dbo.Color");
            DropTable("dbo.Vehiculo");
            DropTable("dbo.Prioridad");
            DropTable("dbo.Cliente");
            DropTable("dbo.Entrega");
            DropTable("dbo.Departamento");
            DropTable("dbo.Empleado");
            DropTable("dbo.Cargo");
        }
    }
}

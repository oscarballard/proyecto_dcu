namespace dentista.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialMigration : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.citas",
                c => new
                    {
                        id_cita = c.Int(nullable: false, identity: true),
                        id_paciente = c.String(),
                        id_doctor = c.String(),
                        fecha_cita = c.DateTime(nullable: false),
                        estado = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.id_cita);
            
            CreateTable(
                "dbo.consultas",
                c => new
                    {
                        id_consulta = c.Int(nullable: false, identity: true),
                        id_paciente = c.Int(nullable: false),
                        id_doctor = c.Int(nullable: false),
                        motivo = c.String(maxLength: 100),
                        id_cita = c.Int(nullable: false),
                        detalle_consulta = c.String(maxLength: 300),
                    })
                .PrimaryKey(t => t.id_consulta);
            
            CreateTable(
                "dbo.empleadoes",
                c => new
                    {
                        id_empleado = c.Int(nullable: false, identity: true),
                        nombre = c.String(maxLength: 100),
                        apellidos = c.String(maxLength: 100),
                        usuario = c.String(maxLength: 100),
                        password = c.String(maxLength: 100),
                        correo = c.String(maxLength: 100),
                        cargo = c.String(maxLength: 100),
                        telefono = c.String(maxLength: 18),
                        estado = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.id_empleado);
            
            CreateTable(
                "dbo.Pacientes",
                c => new
                    {
                        id_paciente = c.Int(nullable: false, identity: true),
                        nombre = c.String(maxLength: 100),
                        apellidos = c.String(maxLength: 100),
                        edad = c.Int(nullable: false),
                        correo = c.String(maxLength: 100),
                        telefono = c.String(maxLength: 100),
                        estado = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.id_paciente);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Pacientes");
            DropTable("dbo.empleadoes");
            DropTable("dbo.consultas");
            DropTable("dbo.citas");
        }
    }
}

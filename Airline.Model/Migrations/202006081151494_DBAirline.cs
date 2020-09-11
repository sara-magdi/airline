namespace Airline.Model.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DBAirline : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.AirCraftCrews",
                c => new
                    {
                        AircraftId = c.Int(nullable: false, identity: true),
                        Capacity = c.Int(nullable: false),
                        Model = c.String(),
                        CrewId = c.Int(nullable: false),
                        Pilot = c.String(maxLength: 30),
                        Assistant = c.String(maxLength: 30),
                        Hostess1 = c.String(maxLength: 30),
                        Hosstess2 = c.String(maxLength: 30),
                    })
                .PrimaryKey(t => t.AircraftId);
            
            CreateTable(
                "dbo.Airlines",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 30),
                        Address = c.String(maxLength: 70),
                        ContactPerson = c.String(),
                        EmployeeId = c.Int(nullable: false),
                        TransactionId = c.Int(nullable: false),
                        AircraftId = c.Int(nullable: false),
                        PhoneId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.AirCraftCrews", t => t.AircraftId, cascadeDelete: true)
                .ForeignKey("dbo.Employees", t => t.EmployeeId, cascadeDelete: true)
                .ForeignKey("dbo.Phones", t => t.PhoneId, cascadeDelete: true)
                .ForeignKey("dbo.Transactions", t => t.TransactionId, cascadeDelete: true)
                .Index(t => t.EmployeeId)
                .Index(t => t.TransactionId)
                .Index(t => t.AircraftId)
                .Index(t => t.PhoneId);
            
            CreateTable(
                "dbo.Employees",
                c => new
                    {
                        EmployeeId = c.Int(nullable: false, identity: true),
                        EmployeeName = c.String(nullable: false, maxLength: 30),
                        Address = c.String(maxLength: 70),
                        Day = c.Int(nullable: false),
                        Month = c.Int(nullable: false),
                        year = c.Int(nullable: false),
                        Position = c.String(maxLength: 30),
                        Gender = c.String(nullable: false),
                        QualificationId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.EmployeeId)
                .ForeignKey("dbo.Qualifications", t => t.QualificationId, cascadeDelete: true)
                .Index(t => t.QualificationId);
            
            CreateTable(
                "dbo.Qualifications",
                c => new
                    {
                        QualificationId = c.Int(nullable: false, identity: true),
                        Qualifications = c.String(),
                    })
                .PrimaryKey(t => t.QualificationId);
            
            CreateTable(
                "dbo.Phones",
                c => new
                    {
                        PhoneId = c.Int(nullable: false, identity: true),
                        PhoneNumber = c.String(),
                    })
                .PrimaryKey(t => t.PhoneId);
            
            CreateTable(
                "dbo.Transactions",
                c => new
                    {
                        TransactionId = c.Int(nullable: false, identity: true),
                        Desc = c.String(),
                        Date = c.DateTime(nullable: false),
                        Amount = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.TransactionId);
            
            CreateTable(
                "dbo.Assigneds",
                c => new
                    {
                        Pass = c.Int(nullable: false, identity: true),
                        price = c.Int(nullable: false),
                        TimeSpent = c.DateTime(nullable: false),
                        DeptDateTime = c.DateTime(nullable: false),
                        RouteId = c.Int(nullable: false),
                        AircraftId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Pass)
                .ForeignKey("dbo.AirCraftCrews", t => t.AircraftId, cascadeDelete: true)
                .ForeignKey("dbo.Routes", t => t.RouteId, cascadeDelete: true)
                .Index(t => t.RouteId)
                .Index(t => t.AircraftId);
            
            CreateTable(
                "dbo.Routes",
                c => new
                    {
                        RouteId = c.Int(nullable: false, identity: true),
                        Origin = c.String(),
                        Distination = c.String(),
                        Classification = c.String(),
                        Distance = c.String(),
                    })
                .PrimaryKey(t => t.RouteId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Assigneds", "RouteId", "dbo.Routes");
            DropForeignKey("dbo.Assigneds", "AircraftId", "dbo.AirCraftCrews");
            DropForeignKey("dbo.Airlines", "TransactionId", "dbo.Transactions");
            DropForeignKey("dbo.Airlines", "PhoneId", "dbo.Phones");
            DropForeignKey("dbo.Airlines", "EmployeeId", "dbo.Employees");
            DropForeignKey("dbo.Employees", "QualificationId", "dbo.Qualifications");
            DropForeignKey("dbo.Airlines", "AircraftId", "dbo.AirCraftCrews");
            DropIndex("dbo.Assigneds", new[] { "AircraftId" });
            DropIndex("dbo.Assigneds", new[] { "RouteId" });
            DropIndex("dbo.Employees", new[] { "QualificationId" });
            DropIndex("dbo.Airlines", new[] { "PhoneId" });
            DropIndex("dbo.Airlines", new[] { "AircraftId" });
            DropIndex("dbo.Airlines", new[] { "TransactionId" });
            DropIndex("dbo.Airlines", new[] { "EmployeeId" });
            DropTable("dbo.Routes");
            DropTable("dbo.Assigneds");
            DropTable("dbo.Transactions");
            DropTable("dbo.Phones");
            DropTable("dbo.Qualifications");
            DropTable("dbo.Employees");
            DropTable("dbo.Airlines");
            DropTable("dbo.AirCraftCrews");
        }
    }
}

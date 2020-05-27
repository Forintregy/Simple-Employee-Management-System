namespace EmployeeManagerModel.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _11 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Departments",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        DepartmentName = c.String(nullable: false, maxLength: 100),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Employees",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FirstName = c.String(nullable: false, maxLength: 50),
                        SecondName = c.String(maxLength: 50),
                        LastName = c.String(nullable: false, maxLength: 50),
                        About = c.String(),
                        DateOfBirth = c.DateTime(nullable: false),
                        DepartmentId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Departments", t => t.DepartmentId, cascadeDelete: true)
                .Index(t => t.DepartmentId);
            
            CreateTable(
                "dbo.Addresses",
                c => new
                    {
                        EmployeeId = c.Int(nullable: false),
                        Country = c.String(nullable: false, maxLength: 70),
                        ZipCode = c.String(maxLength: 20),
                        Region = c.String(maxLength: 100),
                        City = c.String(nullable: false, maxLength: 50),
                        StreetAddress = c.String(nullable: false, maxLength: 100),
                        Apartment = c.String(maxLength: 100),
                    })
                .PrimaryKey(t => t.EmployeeId)
                .ForeignKey("dbo.Employees", t => t.EmployeeId)
                .Index(t => t.EmployeeId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Employees", "DepartmentId", "dbo.Departments");
            DropForeignKey("dbo.Addresses", "EmployeeId", "dbo.Employees");
            DropIndex("dbo.Employees", new[] { "DepartmentId" });
            DropIndex("dbo.Addresses", new[] { "EmployeeId" });
            DropTable("dbo.Addresses");
            DropTable("dbo.Employees");
            DropTable("dbo.Departments");
        }
    }
}

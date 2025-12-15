namespace CodeFirstDemo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Employees",
                c => new
                    {
                        Empid = c.String(nullable: false, maxLength: 128),
                        EmpName = c.String(nullable: false),
                        DepartmentName = c.String(nullable: false),
                        Salary = c.Int(nullable: false),
                        YearOfJoining = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Empid);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Employees");
        }
    }
}

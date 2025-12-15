namespace _15_12_25.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Students",
                c => new
                    {
                        Sid = c.Int(nullable: false),
                        studentfullname = c.String(nullable: false, maxLength: 20, unicode: false),
                        DOB = c.DateTime(nullable: false),
                        Class = c.Int(nullable: false),
                        Emailaddress = c.String(maxLength: 50, unicode: false),
                    })
                .PrimaryKey(t => t.Sid);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Students");
        }
    }
}

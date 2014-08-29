namespace ToDoApp.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initcommit : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ToDoItems",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Title = c.String(),
                        Description = c.String(),
                        UserId = c.Int(nullable: false),
                        Latitude = c.Decimal(nullable: false, precision: 12, scale: 10),
                        Longitude = c.Decimal(nullable: false, precision: 12, scale: 10),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Users", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ToDoItems", "UserId", "dbo.Users");
            DropIndex("dbo.ToDoItems", new[] { "UserId" });
            DropTable("dbo.Users");
            DropTable("dbo.ToDoItems");
        }
    }
}

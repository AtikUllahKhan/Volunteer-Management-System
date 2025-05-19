namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitDB : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Admins",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Username = c.String(),
                        Password = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Events",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Description = c.String(),
                        Date = c.DateTime(nullable: false),
                        AdminId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Admins", t => t.AdminId, cascadeDelete: true)
                .Index(t => t.AdminId);
            
            CreateTable(
                "dbo.Volunteers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Contact = c.String(),
                        Skill = c.String(),
                        Availability = c.String(),
                        EventId = c.Int(),
                        AdminId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Admins", t => t.AdminId)
                .ForeignKey("dbo.Events", t => t.EventId)
                .Index(t => t.EventId)
                .Index(t => t.AdminId);
            
            CreateTable(
                "dbo.Tokens",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Key = c.String(),
                        CreateAt = c.DateTime(nullable: false),
                        ExpireAt = c.DateTime(),
                        AdminId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Admins", t => t.AdminId, cascadeDelete: true)
                .Index(t => t.AdminId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Tokens", "AdminId", "dbo.Admins");
            DropForeignKey("dbo.Volunteers", "EventId", "dbo.Events");
            DropForeignKey("dbo.Volunteers", "AdminId", "dbo.Admins");
            DropForeignKey("dbo.Events", "AdminId", "dbo.Admins");
            DropIndex("dbo.Tokens", new[] { "AdminId" });
            DropIndex("dbo.Volunteers", new[] { "AdminId" });
            DropIndex("dbo.Volunteers", new[] { "EventId" });
            DropIndex("dbo.Events", new[] { "AdminId" });
            DropTable("dbo.Tokens");
            DropTable("dbo.Volunteers");
            DropTable("dbo.Events");
            DropTable("dbo.Admins");
        }
    }
}

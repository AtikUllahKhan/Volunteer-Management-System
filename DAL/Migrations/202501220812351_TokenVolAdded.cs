namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class TokenVolAdded : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.TokenVols",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Key = c.String(),
                        CreateAt = c.DateTime(nullable: false),
                        ExpireAt = c.DateTime(),
                        VolunteerId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Volunteers", t => t.VolunteerId, cascadeDelete: true)
                .Index(t => t.VolunteerId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.TokenVols", "VolunteerId", "dbo.Volunteers");
            DropIndex("dbo.TokenVols", new[] { "VolunteerId" });
            DropTable("dbo.TokenVols");
        }
    }
}

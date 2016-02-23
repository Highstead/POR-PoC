namespace PoR.Logic.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class update : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.BookedItems",
                c => new
                    {
                        BookedItemId = c.Int(nullable: false, identity: true),
                        StartTime = c.DateTime(nullable: false),
                        EndTime = c.DateTime(nullable: false),
                        Quantity = c.Int(nullable: false),
                        CreatedDateUtc = c.DateTime(nullable: false, defaultValueSql: "GETUTCDATE()"),
                        ClientId = c.Int(nullable: false),
                        ItemId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.BookedItemId)
                .ForeignKey("dbo.Clients", t => t.ClientId, cascadeDelete: true)
                .ForeignKey("dbo.Items", t => t.ItemId, cascadeDelete: true)
                .Index(t => t.ClientId)
                .Index(t => t.ItemId);
            
            CreateTable(
                "dbo.Clients",
                c => new
                    {
                        ClientId = c.Int(nullable: false, identity: true),
                        FirstName = c.String(),
                        LastName = c.String(),
                    })
                .PrimaryKey(t => t.ClientId);
            
            CreateTable(
                "dbo.Items",
                c => new
                    {
                        ItemId = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Category = c.String(),
                        Quantity = c.Int(nullable: false),
                        CreatedDateUtc = c.DateTime(nullable: false, defaultValueSql: "GETUTCDATE()"),
                    })
                .PrimaryKey(t => t.ItemId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.BookedItems", "ItemId", "dbo.Items");
            DropForeignKey("dbo.BookedItems", "ClientId", "dbo.Clients");
            DropIndex("dbo.BookedItems", new[] { "ItemId" });
            DropIndex("dbo.BookedItems", new[] { "ClientId" });
            DropTable("dbo.Items");
            DropTable("dbo.Clients");
            DropTable("dbo.BookedItems");
        }
    }
}

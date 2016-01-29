namespace Logic.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
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
                        Client_ClientId = c.Int(),
                        Item_ItemId = c.Int(),
                    })
                .PrimaryKey(t => t.BookedItemId)
                .ForeignKey("dbo.Clients", t => t.Client_ClientId)
                .ForeignKey("dbo.Items", t => t.Item_ItemId)
                .Index(t => t.Client_ClientId)
                .Index(t => t.Item_ItemId);
            
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
            DropForeignKey("dbo.BookedItems", "Item_ItemId", "dbo.Items");
            DropForeignKey("dbo.BookedItems", "Client_ClientId", "dbo.Clients");
            DropIndex("dbo.BookedItems", new[] { "Item_ItemId" });
            DropIndex("dbo.BookedItems", new[] { "Client_ClientId" });
            DropTable("dbo.Items");
            DropTable("dbo.Clients");
            DropTable("dbo.BookedItems");
        }
    }
}

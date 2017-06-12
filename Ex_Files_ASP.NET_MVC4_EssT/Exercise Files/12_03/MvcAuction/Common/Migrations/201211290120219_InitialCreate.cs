namespace Common.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Auctions",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        Category = c.String(nullable: false),
                        Title = c.String(nullable: false, maxLength: 200),
                        Description = c.String(),
                        ImageUrl = c.String(),
                        StartTime = c.DateTime(nullable: false),
                        EndTime = c.DateTime(nullable: false),
                        StartPrice = c.Decimal(nullable: false, precision: 18, scale: 2),
                        CurrentPrice = c.Decimal(precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Bids",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        AuctionId = c.Long(nullable: false),
                        Timestamp = c.DateTime(nullable: false),
                        Username = c.String(),
                        Amount = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Auctions", t => t.AuctionId, cascadeDelete: true)
                .Index(t => t.AuctionId);
            
        }
        
        public override void Down()
        {
            DropIndex("dbo.Bids", new[] { "AuctionId" });
            DropForeignKey("dbo.Bids", "AuctionId", "dbo.Auctions");
            DropTable("dbo.Bids");
            DropTable("dbo.Auctions");
        }
    }
}

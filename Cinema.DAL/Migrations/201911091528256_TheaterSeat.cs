namespace Cinema.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class TheaterSeat : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Seats", "TheaterId", "dbo.Theaters");
            DropIndex("dbo.Seats", new[] { "TheaterId" });
            CreateTable(
                "dbo.TheaterSeat",
                c => new
                    {
                        SeatId = c.Guid(nullable: false),
                        TheaterId = c.Guid(nullable: false),
                    })
                .PrimaryKey(t => new { t.SeatId, t.TheaterId })
                .ForeignKey("dbo.Seats", t => t.SeatId, cascadeDelete: true)
                .ForeignKey("dbo.Theaters", t => t.TheaterId, cascadeDelete: true)
                .Index(t => t.SeatId)
                .Index(t => t.TheaterId);
            
            DropColumn("dbo.Seats", "TheaterId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Seats", "TheaterId", c => c.Guid(nullable: false));
            DropForeignKey("dbo.TheaterSeat", "TheaterId", "dbo.Theaters");
            DropForeignKey("dbo.TheaterSeat", "SeatId", "dbo.Seats");
            DropIndex("dbo.TheaterSeat", new[] { "TheaterId" });
            DropIndex("dbo.TheaterSeat", new[] { "SeatId" });
            DropTable("dbo.TheaterSeat");
            CreateIndex("dbo.Seats", "TheaterId");
            AddForeignKey("dbo.Seats", "TheaterId", "dbo.Theaters", "Id");
        }
    }
}

namespace Cinema.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class deletelog : DbMigration
    {
        public override void Up()
        {
            DropTable("dbo.Logs");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.Logs",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Table = c.String(nullable: false, maxLength: 50, unicode: false),
                        ProcessType = c.Int(nullable: false),
                        Data = c.String(nullable: false, unicode: false),
                        CreatedDate = c.DateTime(nullable: false),
                        UserId = c.Guid(nullable: false),
                        RoleId = c.Guid(nullable: false),
                        RowGuid = c.Guid(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
    }
}

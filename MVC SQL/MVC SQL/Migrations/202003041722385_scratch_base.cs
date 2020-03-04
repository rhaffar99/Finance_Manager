namespace MVC_SQL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class scratch_base : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.TestFinanceModels",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        MarketTicker = c.String(),
                        CurrentValue = c.Double(nullable: false),
                        PercentageChange = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.TestFinanceModels");
        }
    }
}

namespace MVC_SQL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class localdbdesktoprefresh : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.DailyFinanceModels",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        open = c.Double(nullable: false),
                        high = c.Double(nullable: false),
                        low = c.Double(nullable: false),
                        close = c.Double(nullable: false),
                        adjusted_close = c.Double(nullable: false),
                        volume = c.String(),
                        dividend_amount = c.Double(nullable: false),
                        split_coefficient = c.Double(nullable: false),
                        market_ticker = c.String(),
                        date = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
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
            
            CreateTable(
                "dbo.MonthlyFinanceModels",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        open = c.Double(nullable: false),
                        high = c.Double(nullable: false),
                        low = c.Double(nullable: false),
                        close = c.Double(nullable: false),
                        adjusted_close = c.Double(nullable: false),
                        volume = c.String(),
                        dividend_amount = c.Double(nullable: false),
                        market_ticker = c.String(),
                        date = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.WeeklyFinanceModels",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        open = c.Double(nullable: false),
                        high = c.Double(nullable: false),
                        low = c.Double(nullable: false),
                        close = c.Double(nullable: false),
                        adjusted_close = c.Double(nullable: false),
                        volume = c.String(),
                        dividend_amount = c.Double(nullable: false),
                        market_ticker = c.String(),
                        date = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.WeeklyFinanceModels");
            DropTable("dbo.MonthlyFinanceModels");
            DropTable("dbo.TestFinanceModels");
            DropTable("dbo.DailyFinanceModels");
        }
    }
}

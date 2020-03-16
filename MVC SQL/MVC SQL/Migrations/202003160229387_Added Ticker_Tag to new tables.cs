namespace MVC_SQL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedTicker_Tagtonewtables : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.DailyFinanceModels", "market_ticker", c => c.String());
            AddColumn("dbo.MonthlyFinanceModels", "market_ticker", c => c.String());
            AddColumn("dbo.WeeklyFinanceModels", "market_ticker", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.WeeklyFinanceModels", "market_ticker");
            DropColumn("dbo.MonthlyFinanceModels", "market_ticker");
            DropColumn("dbo.DailyFinanceModels", "market_ticker");
        }
    }
}

namespace MVC_SQL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddeddateTime : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.DailyFinanceModels", "date", c => c.DateTime(nullable: false));
            AddColumn("dbo.MonthlyFinanceModels", "date", c => c.DateTime(nullable: false));
            AddColumn("dbo.WeeklyFinanceModels", "date", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.WeeklyFinanceModels", "date");
            DropColumn("dbo.MonthlyFinanceModels", "date");
            DropColumn("dbo.DailyFinanceModels", "date");
        }
    }
}

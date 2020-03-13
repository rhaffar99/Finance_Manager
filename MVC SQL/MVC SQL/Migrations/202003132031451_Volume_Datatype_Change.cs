namespace MVC_SQL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Volume_Datatype_Change : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.DailyFinanceModels", "volume", c => c.String());
            AlterColumn("dbo.MonthlyFinanceModels", "volume", c => c.String());
            AlterColumn("dbo.WeeklyFinanceModels", "volume", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.WeeklyFinanceModels", "volume", c => c.Double(nullable: false));
            AlterColumn("dbo.MonthlyFinanceModels", "volume", c => c.Double(nullable: false));
            AlterColumn("dbo.DailyFinanceModels", "volume", c => c.Double(nullable: false));
        }
    }
}

namespace MVC_SQL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class NewTestFinanceModel : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.TestFinanceModels", "PercentageChange", c => c.Int(nullable: false));
            DropColumn("dbo.TestFinanceModels", "FinanceVehicle");
            DropColumn("dbo.TestFinanceModels", "PreviousMonthValue");
        }
        
        public override void Down()
        {
            AddColumn("dbo.TestFinanceModels", "PreviousMonthValue", c => c.Int(nullable: false));
            AddColumn("dbo.TestFinanceModels", "FinanceVehicle", c => c.String());
            DropColumn("dbo.TestFinanceModels", "PercentageChange");
        }
    }
}

namespace MVC_SQL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Update_Finance_Model : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.TestFinanceModels", "CurrentValue", c => c.Double(nullable: false));
            AlterColumn("dbo.TestFinanceModels", "PercentageChange", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.TestFinanceModels", "PercentageChange", c => c.Int(nullable: false));
            AlterColumn("dbo.TestFinanceModels", "CurrentValue", c => c.Int(nullable: false));
        }
    }
}

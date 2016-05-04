namespace GoldChallenge.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DollarSign : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.CustomerBackgrounds", "CashInvestment", c => c.Decimal(nullable: false, storeType: "money"));
            AlterColumn("dbo.CustomerBackgrounds", "NetWorth", c => c.Decimal(nullable: false, storeType: "money"));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.CustomerBackgrounds", "NetWorth", c => c.String());
            AlterColumn("dbo.CustomerBackgrounds", "CashInvestment", c => c.String(nullable: false));
        }
    }
}

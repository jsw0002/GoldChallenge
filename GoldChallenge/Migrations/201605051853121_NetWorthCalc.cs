namespace GoldChallenge.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class NetWorthCalc : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.NetWorthCalculators",
                c => new
                    {
                        CustomerID = c.Int(nullable: false, identity: true),
                        CashInCheckingAndSavings = c.Decimal(nullable: false, precision: 18, scale: 2),
                        StocksBondsMutualFunds = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Ira401kOtherRetirementPlans = c.Decimal(nullable: false, precision: 18, scale: 2),
                        RealEstateHome = c.Decimal(nullable: false, precision: 18, scale: 2),
                        RealEstateOther = c.Decimal(nullable: false, precision: 18, scale: 2),
                        BusinessValue = c.Decimal(nullable: false, precision: 18, scale: 2),
                        AppraisedCollectibles = c.Decimal(nullable: false, precision: 18, scale: 2),
                        MoneyOwedToYou = c.Decimal(nullable: false, precision: 18, scale: 2),
                        OtherAssets = c.Decimal(nullable: false, precision: 18, scale: 2),
                        MortgageHome = c.Decimal(nullable: false, precision: 18, scale: 2),
                        MortgageOther = c.Decimal(nullable: false, precision: 18, scale: 2),
                        ChargeAccountsCreditCards = c.Decimal(nullable: false, precision: 18, scale: 2),
                        AutomobileLoans = c.Decimal(nullable: false, precision: 18, scale: 2),
                        OtherLiabilities = c.Decimal(nullable: false, precision: 18, scale: 2),
                        TotalAssets = c.Decimal(nullable: false, precision: 18, scale: 2),
                        TotalLiabilities = c.Decimal(nullable: false, precision: 18, scale: 2),
                        TaMinusTl = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.CustomerID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.NetWorthCalculators");
        }
    }
}

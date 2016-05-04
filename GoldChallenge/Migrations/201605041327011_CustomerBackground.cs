namespace GoldChallenge.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CustomerBackground : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.CustomerBackgrounds",
                c => new
                    {
                        CustomerID = c.Int(nullable: false, identity: true),
                        AreThereAnyOtherDecisionMakers = c.Boolean(nullable: false),
                        IsMarried = c.Boolean(nullable: false),
                        SpouseName = c.String(),
                        CurrentOccupation = c.String(nullable: false),
                        ProfessionalBackground1 = c.String(),
                        ProfessionalBackground2 = c.String(),
                        ProfessionalBackground3 = c.String(),
                        ProfessionalBackground4 = c.String(),
                        ProfessionalBackground5 = c.String(),
                        AreYouAVet = c.Boolean(nullable: false),
                        HaveYouOwnedABusinessBefore = c.Boolean(nullable: false),
                        CreditScore = c.String(),
                        CashInvestment = c.String(nullable: false),
                        InvestmentSource = c.String(nullable: false),
                        NetWorth = c.String(),
                        DesiredMarket = c.String(nullable: false),
                        WhyAreYouLookingAtBusinesses = c.String(nullable: false),
                        LengthOfTimeLooking = c.String(nullable: false),
                        SpokenWithAnyoneElse = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.CustomerID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.CustomerBackgrounds");
        }
    }
}

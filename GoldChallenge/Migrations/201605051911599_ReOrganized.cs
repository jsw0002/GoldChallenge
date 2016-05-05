namespace GoldChallenge.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ReOrganized : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.CustomerPreferences",
                c => new
                    {
                        CustomerID = c.Int(nullable: false, identity: true),
                        IdealSituation = c.String(),
                        BusinessPreference = c.String(),
                        StaffSizePreference = c.String(),
                        MultipleLocations = c.Boolean(nullable: false),
                        WhatIsYourTimeFrame = c.String(),
                        SalesSkills = c.String(),
                        ColdCalling = c.String(),
                        DirectVsAdvertising = c.String(),
                        WhiteVsBlueColar = c.String(),
                        EstablishedVsNewConcept = c.String(),
                        SmallVsLargeFranchiseSystem = c.String(),
                        CompetitiveVsOnlyGameInTown = c.String(),
                        PrestigeOrNotImportant = c.String(),
                        BusinessToBusinessVsBusinessToConsumer = c.String(),
                        HoursPreference = c.String(),
                        AnyMoreInformation = c.String(),
                    })
                .PrimaryKey(t => t.CustomerID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.CustomerPreferences");
        }
    }
}

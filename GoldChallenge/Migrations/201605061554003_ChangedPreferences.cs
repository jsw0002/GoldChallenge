namespace GoldChallenge.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangedPreferences : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.CustomerPreferences", "IdealSituation", c => c.Int(nullable: false));
            AlterColumn("dbo.CustomerPreferences", "BusinessPreference", c => c.Int(nullable: false));
            AlterColumn("dbo.CustomerPreferences", "StaffSizePreference", c => c.Int(nullable: false));
            AlterColumn("dbo.CustomerPreferences", "ColdCallingPhone", c => c.Int(nullable: false));
            AlterColumn("dbo.CustomerPreferences", "ColdCallingInPerson", c => c.Int(nullable: false));
            AlterColumn("dbo.CustomerPreferences", "DirectVsAdvertising", c => c.Int(nullable: false));
            AlterColumn("dbo.CustomerPreferences", "WhiteVsBlueColar", c => c.Int(nullable: false));
            AlterColumn("dbo.CustomerPreferences", "EstablishedVsNewConcept", c => c.Int(nullable: false));
            AlterColumn("dbo.CustomerPreferences", "SmallVsLargeFranchiseSystem", c => c.Int(nullable: false));
            AlterColumn("dbo.CustomerPreferences", "CompetitiveVsOnlyGameInTown", c => c.Int(nullable: false));
            AlterColumn("dbo.CustomerPreferences", "PrestigeOrNotImportant", c => c.Int(nullable: false));
            AlterColumn("dbo.CustomerPreferences", "BusinessToBusinessVsBusinessToConsumer", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.CustomerPreferences", "BusinessToBusinessVsBusinessToConsumer", c => c.Boolean(nullable: false));
            AlterColumn("dbo.CustomerPreferences", "PrestigeOrNotImportant", c => c.Boolean(nullable: false));
            AlterColumn("dbo.CustomerPreferences", "CompetitiveVsOnlyGameInTown", c => c.Boolean(nullable: false));
            AlterColumn("dbo.CustomerPreferences", "SmallVsLargeFranchiseSystem", c => c.Boolean(nullable: false));
            AlterColumn("dbo.CustomerPreferences", "EstablishedVsNewConcept", c => c.Boolean(nullable: false));
            AlterColumn("dbo.CustomerPreferences", "WhiteVsBlueColar", c => c.Boolean(nullable: false));
            AlterColumn("dbo.CustomerPreferences", "DirectVsAdvertising", c => c.Boolean(nullable: false));
            AlterColumn("dbo.CustomerPreferences", "ColdCallingInPerson", c => c.Boolean(nullable: false));
            AlterColumn("dbo.CustomerPreferences", "ColdCallingPhone", c => c.Boolean(nullable: false));
            AlterColumn("dbo.CustomerPreferences", "StaffSizePreference", c => c.Boolean(nullable: false));
            AlterColumn("dbo.CustomerPreferences", "BusinessPreference", c => c.Boolean(nullable: false));
            AlterColumn("dbo.CustomerPreferences", "IdealSituation", c => c.Boolean(nullable: false));
        }
    }
}

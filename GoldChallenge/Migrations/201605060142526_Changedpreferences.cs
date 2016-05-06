namespace GoldChallenge.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Changedpreferences : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.CustomerPreferences", "TopThreePerfectBusinessOpportunity1", c => c.String());
            AddColumn("dbo.CustomerPreferences", "TopThreePerfectBusinessOpportunity2", c => c.String());
            AddColumn("dbo.CustomerPreferences", "TopThreePerfectBusinessOpportunity3", c => c.String());
            AddColumn("dbo.CustomerPreferences", "RankTheseSkills1", c => c.String());
            AddColumn("dbo.CustomerPreferences", "RankTheseSkills2", c => c.String());
            AddColumn("dbo.CustomerPreferences", "RankTheseSkills3", c => c.String());
            AddColumn("dbo.CustomerPreferences", "RankTheseSkills4", c => c.String());
            AddColumn("dbo.CustomerPreferences", "RankTheseSkills5", c => c.String());
            AddColumn("dbo.CustomerPreferences", "TopThreeNonBusinessSkills1", c => c.String());
            AddColumn("dbo.CustomerPreferences", "TopThreeNonBusinessSkills2", c => c.String());
            AddColumn("dbo.CustomerPreferences", "TopThreeNonBusinessSkills3", c => c.String());
            AddColumn("dbo.CustomerPreferences", "SalesSkillsExplanation", c => c.String());
            AlterColumn("dbo.CustomerPreferences", "IdealSituation", c => c.Boolean(nullable: false));
            AlterColumn("dbo.CustomerPreferences", "BusinessPreference", c => c.Boolean(nullable: false));
            AlterColumn("dbo.CustomerPreferences", "StaffSizePreference", c => c.Boolean(nullable: false));
            AlterColumn("dbo.CustomerPreferences", "ColdCallingPhone", c => c.Boolean(nullable: false));
            AlterColumn("dbo.CustomerPreferences", "ColdCallingInPerson", c => c.Boolean(nullable: false));
            AlterColumn("dbo.CustomerPreferences", "DirectVsAdvertising", c => c.Boolean(nullable: false));
            AlterColumn("dbo.CustomerPreferences", "WhiteVsBlueColar", c => c.Boolean(nullable: false));
            AlterColumn("dbo.CustomerPreferences", "EstablishedVsNewConcept", c => c.Boolean(nullable: false));
            AlterColumn("dbo.CustomerPreferences", "SmallVsLargeFranchiseSystem", c => c.Boolean(nullable: false));
            AlterColumn("dbo.CustomerPreferences", "CompetitiveVsOnlyGameInTown", c => c.Boolean(nullable: false));
            AlterColumn("dbo.CustomerPreferences", "PrestigeOrNotImportant", c => c.Boolean(nullable: false));
            AlterColumn("dbo.CustomerPreferences", "BusinessToBusinessVsBusinessToConsumer", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.CustomerPreferences", "BusinessToBusinessVsBusinessToConsumer", c => c.String());
            AlterColumn("dbo.CustomerPreferences", "PrestigeOrNotImportant", c => c.String());
            AlterColumn("dbo.CustomerPreferences", "CompetitiveVsOnlyGameInTown", c => c.String());
            AlterColumn("dbo.CustomerPreferences", "SmallVsLargeFranchiseSystem", c => c.String());
            AlterColumn("dbo.CustomerPreferences", "EstablishedVsNewConcept", c => c.String());
            AlterColumn("dbo.CustomerPreferences", "WhiteVsBlueColar", c => c.String());
            AlterColumn("dbo.CustomerPreferences", "DirectVsAdvertising", c => c.String());
            AlterColumn("dbo.CustomerPreferences", "ColdCallingInPerson", c => c.String());
            AlterColumn("dbo.CustomerPreferences", "ColdCallingPhone", c => c.String());
            AlterColumn("dbo.CustomerPreferences", "StaffSizePreference", c => c.String());
            AlterColumn("dbo.CustomerPreferences", "BusinessPreference", c => c.String());
            AlterColumn("dbo.CustomerPreferences", "IdealSituation", c => c.String());
            DropColumn("dbo.CustomerPreferences", "SalesSkillsExplanation");
            DropColumn("dbo.CustomerPreferences", "TopThreeNonBusinessSkills3");
            DropColumn("dbo.CustomerPreferences", "TopThreeNonBusinessSkills2");
            DropColumn("dbo.CustomerPreferences", "TopThreeNonBusinessSkills1");
            DropColumn("dbo.CustomerPreferences", "RankTheseSkills5");
            DropColumn("dbo.CustomerPreferences", "RankTheseSkills4");
            DropColumn("dbo.CustomerPreferences", "RankTheseSkills3");
            DropColumn("dbo.CustomerPreferences", "RankTheseSkills2");
            DropColumn("dbo.CustomerPreferences", "RankTheseSkills1");
            DropColumn("dbo.CustomerPreferences", "TopThreePerfectBusinessOpportunity3");
            DropColumn("dbo.CustomerPreferences", "TopThreePerfectBusinessOpportunity2");
            DropColumn("dbo.CustomerPreferences", "TopThreePerfectBusinessOpportunity1");
        }
    }
}

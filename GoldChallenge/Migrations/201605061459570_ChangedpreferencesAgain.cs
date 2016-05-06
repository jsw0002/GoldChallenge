namespace GoldChallenge.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangedpreferencesAgain : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.CustomerPreferences", "HoursPreferenceMonFri", c => c.Boolean(nullable: false));
            AddColumn("dbo.CustomerPreferences", "HoursPreferenceNoNights", c => c.Boolean(nullable: false));
            AddColumn("dbo.CustomerPreferences", "HoursPreferenceNoSaturdays", c => c.Boolean(nullable: false));
            AddColumn("dbo.CustomerPreferences", "HoursPreferenceNoSundays", c => c.Boolean(nullable: false));
            AddColumn("dbo.CustomerPreferences", "HoursPreferenceNoPreference", c => c.Boolean(nullable: false));
            DropColumn("dbo.CustomerPreferences", "HoursPreference");
        }
        
        public override void Down()
        {
            AddColumn("dbo.CustomerPreferences", "HoursPreference", c => c.String());
            DropColumn("dbo.CustomerPreferences", "HoursPreferenceNoPreference");
            DropColumn("dbo.CustomerPreferences", "HoursPreferenceNoSundays");
            DropColumn("dbo.CustomerPreferences", "HoursPreferenceNoSaturdays");
            DropColumn("dbo.CustomerPreferences", "HoursPreferenceNoNights");
            DropColumn("dbo.CustomerPreferences", "HoursPreferenceMonFri");
        }
    }
}

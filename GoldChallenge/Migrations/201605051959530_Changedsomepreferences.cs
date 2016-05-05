namespace GoldChallenge.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Changedsomepreferences : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.CustomerPreferences", "ColdCallingPhone", c => c.String());
            AddColumn("dbo.CustomerPreferences", "ColdCallingInPerson", c => c.String());
            DropColumn("dbo.CustomerPreferences", "ColdCalling");
        }
        
        public override void Down()
        {
            AddColumn("dbo.CustomerPreferences", "ColdCalling", c => c.String());
            DropColumn("dbo.CustomerPreferences", "ColdCallingInPerson");
            DropColumn("dbo.CustomerPreferences", "ColdCallingPhone");
        }
    }
}

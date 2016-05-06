namespace GoldChallenge.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangedPreferences : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.CustomerPreferences", "SalesSkills", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.CustomerPreferences", "SalesSkills", c => c.String());
        }
    }
}

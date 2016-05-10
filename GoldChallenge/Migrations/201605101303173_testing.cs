namespace GoldChallenge.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class testing : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.CustomerBackgrounds", "CreditScore", c => c.String());
            AlterColumn("dbo.CustomerBackgrounds", "LengthOfTimeLooking", c => c.String(nullable: false));
            AlterColumn("dbo.Customers", "SourceOfLead", c => c.String());
            DropColumn("dbo.CustomerBackgrounds", "WhoHaveYouSpokenWith");
        }
        
        public override void Down()
        {
            AddColumn("dbo.CustomerBackgrounds", "WhoHaveYouSpokenWith", c => c.String());
            AlterColumn("dbo.Customers", "SourceOfLead", c => c.Int(nullable: false));
            AlterColumn("dbo.CustomerBackgrounds", "LengthOfTimeLooking", c => c.Int(nullable: false));
            AlterColumn("dbo.CustomerBackgrounds", "CreditScore", c => c.Int(nullable: false));
        }
    }
}

namespace GoldChallenge.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Customers", "ZipCode", c => c.String(nullable: false));
            AlterColumn("dbo.Customers", "Phone", c => c.String(nullable: false));
            AlterColumn("dbo.FranchiseContacts", "ZipCode", c => c.String(nullable: false));
            AlterColumn("dbo.FranchiseContacts", "Phone", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.FranchiseContacts", "Phone", c => c.Int(nullable: false));
            AlterColumn("dbo.FranchiseContacts", "ZipCode", c => c.Int(nullable: false));
            AlterColumn("dbo.Customers", "Phone", c => c.Int(nullable: false));
            AlterColumn("dbo.Customers", "ZipCode", c => c.Int(nullable: false));
        }
    }
}

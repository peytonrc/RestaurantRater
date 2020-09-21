namespace RestaurantRater.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class IntToDouble : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Restaurants", "Rating", c => c.Double(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Restaurants", "Rating", c => c.Int(nullable: false));
        }
    }
}

namespace WooxTravel.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Destination_Update_Column_Capacity : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Destinations", "Capacity", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Destinations", "Capacity");
        }
    }
}

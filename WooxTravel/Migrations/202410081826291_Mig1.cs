namespace WooxTravel.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Mig1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Rezervations",
                c => new
                    {
                        RezervationID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Email = c.String(),
                        Phone = c.String(),
                        PersonCount = c.Int(nullable: false),
                        RezervationDate = c.DateTime(nullable: false),
                        Description = c.String(),
                    })
                .PrimaryKey(t => t.RezervationID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Rezervations");
        }
    }
}

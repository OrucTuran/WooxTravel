namespace WooxTravel.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Add_Class_Message : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Messages",
                c => new
                    {
                        MessageID = c.Int(nullable: false, identity: true),
                        SendMail = c.String(),
                        ReceiverMail = c.String(),
                        Subject = c.String(),
                        Content = c.String(),
                        SendDate = c.DateTime(nullable: false),
                        IsRead = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.MessageID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Messages");
        }
    }
}

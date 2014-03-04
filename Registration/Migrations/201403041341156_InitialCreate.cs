namespace Registration.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.RegistrationModels",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        FullName = c.String(nullable: false),
                        Gender = c.String(nullable: false),
                        EmailAddress = c.String(nullable: false),
                        HearAbout = c.String(nullable: false),
                        PhoneNo = c.Int(nullable: false),
                        SkypeID = c.String(nullable: false),
                        Area = c.String(nullable: false),
                        Instituition = c.String(nullable: false),
                        FacebookURL = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.RegistrationModels");
        }
    }
}

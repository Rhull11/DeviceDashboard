namespace DeviceDashboard.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.DeviceConfigs",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        IpAddress = c.String(),
                        DeviceName = c.String(),
                        RunDuration = c.String(),
                        EmailAddress = c.String(),
                        EmailPassword = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.DeviceConfigs");
        }
    }
}

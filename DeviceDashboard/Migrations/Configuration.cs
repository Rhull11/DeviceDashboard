namespace DeviceDashboard.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<DeviceDashboard.Models.DeviceDashboardDb>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            ContextKey = "DeviceDashboard.Models.DeviceDashboardDb";
        }

        protected override void Seed(DeviceDashboard.Models.DeviceDashboardDb context)
        {
            
        }
    }
}

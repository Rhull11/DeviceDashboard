using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace DeviceDashboard.Models
{
    public class DeviceDashboardDb : DbContext
    {
        public DeviceDashboardDb() : base("name=DefaultConnection")
        {

        }
        public DbSet<DeviceConfig> DeviceConfigs { get; set; }
    }
}
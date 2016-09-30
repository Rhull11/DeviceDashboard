using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DeviceDashboard.Models
{
    public class DeviceConfig
    {
        public int ID { get; set; }
        public string IpAddress { get; set; }
        public string DeviceName { get; set; }
        public string RunDuration { get; set; }
        public string EmailAddress { get; set; }
        public string EmailPassword { get; set; }
    }
}
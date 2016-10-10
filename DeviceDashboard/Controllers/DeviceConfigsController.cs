using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using DeviceDashboard.Models;

namespace DeviceDashboard.Controllers
{
    public class DeviceConfigsController : ApiController
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: api/DeviceConfigs
        public IQueryable<DeviceConfig> GetDeviceConfigs()
        {
            return db.DeviceConfigs;
        }

        // GET: api/DeviceConfigs/5
        [ResponseType(typeof(DeviceConfig))]
        public IHttpActionResult GetDeviceConfig(int id)
        {
            DeviceConfig deviceConfig = db.DeviceConfigs.Find(id);
            if (deviceConfig == null)
            {
                return NotFound();
            }

            return Ok(deviceConfig);
        }

        //// GET: api/DeviceConfigs/latest
        //[ResponseType(typeof(DeviceConfig))]
        //public IHttpActionResult GetLatestDeviceConfig(int id)
        //{
        //    id = db.DeviceConfigs.Max(u => u.ID);
        //    DeviceConfig deviceConfig = deviceConfig = db.DeviceConfigs.Find(id);
      
        //    if (deviceConfig == null)
        //    {
        //        return NotFound();
        //    }

        //    return Ok(deviceConfig);
        //}

        // PUT: api/DeviceConfigs/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutDeviceConfig(int id, DeviceConfig deviceConfig)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != deviceConfig.ID)
            {
                return BadRequest();
            }

            db.Entry(deviceConfig).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!DeviceConfigExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return StatusCode(HttpStatusCode.NoContent);
        }

        // POST: api/DeviceConfigs
        [ResponseType(typeof(DeviceConfig))]
        public IHttpActionResult PostDeviceConfig(DeviceConfig deviceConfig)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.DeviceConfigs.Add(deviceConfig);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = deviceConfig.ID }, deviceConfig);
        }

        // DELETE: api/DeviceConfigs/5
        [ResponseType(typeof(DeviceConfig))]
        public IHttpActionResult DeleteDeviceConfig(int id)
        {
            DeviceConfig deviceConfig = db.DeviceConfigs.Find(id);
            if (deviceConfig == null)
            {
                return NotFound();
            }

            db.DeviceConfigs.Remove(deviceConfig);
            db.SaveChanges();

            return Ok(deviceConfig);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool DeviceConfigExists(int id)
        {
            return db.DeviceConfigs.Count(e => e.ID == id) > 0;
        }
    }
}
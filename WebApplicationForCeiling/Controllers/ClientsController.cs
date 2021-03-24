using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplicationForCeiling.Models;

namespace WebApplicationForCeiling.Controllers
{
    public class ClientsController : Controller
    {
       [HttpGet]
        public IActionResult Index()
        {
            using (var db = new AppDbContext())
            {
                return Json(db.Clients.Include(e => e.Orders).ToList());
            }
        }

        [Route("Clients/{id}"), HttpGet]
        public IActionResult Get(int id)
        {
            using (var db = new AppDbContext())
            {
                var client = db.Clients.Where(c => c.ClientId == id).FirstOrDefault();
                if (client == null) return NotFound();

                return Json(client);
            }
        }

        [ActionName("Index"), HttpPost]
        public IActionResult Create([FromBody] Client client)
        {
            using (var db = new AppDbContext())
            {
                db.Clients.Add(client);
                db.SaveChanges();
                return Json(client);
            }
        }
               
        [Route("Clients/{id}")]
        [HttpPut]
        public IActionResult Update(int id, [FromBody] Client clientdata)
        {
            using (var db = new AppDbContext())
            {
                var client = db.Clients.Where(c => c.ClientId == id).FirstOrDefault();
                if (client == null) return NotFound();

                client.FirstName = clientdata.FirstName;
                client.LastName = clientdata.LastName;
                db.SaveChanges();
                return Json(client);
            }
        }

        [Route("Clients/{id}"), HttpDelete]
        public IActionResult Delete(int id)
        {
            using (var db = new AppDbContext())
            {
                var client = db.Clients.Where(c => c.ClientId == id).FirstOrDefault();
                if (client == null) return NotFound();

                db.Clients.Remove(client);
                db.SaveChanges();
                return Ok();
            }
        }
    }
}

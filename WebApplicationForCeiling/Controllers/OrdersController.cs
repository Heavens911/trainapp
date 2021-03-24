using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplicationForCeiling.Models;

namespace WebApplicationForCeiling.Controllers
{
    public class OrdersController : Controller
    {
        [Route("Clients/{clientId}/Orders"), HttpGet]
        public IActionResult Index(int clientId)
        {
            using (var db = new AppDbContext())
            {
                return Json(db.Orders
                    .Where(o => o.ClientId == clientId)
                    .Select(o => new
                    {
                        o.OrderId,
                        o.OrderName
                    })
                    .ToList());
            }
        }

        [Route("Clients/{clientId}/Orders/{orderId}"), HttpGet]
        public IActionResult Get(int clientId, int orderId)
        {
            using (var db = new AppDbContext())
            {
                var order = db.Orders.Where(o => o.OrderId == orderId).FirstOrDefault();
                if (order == null) return NotFound();
                if (order.ClientId != clientId) return NotFound();

                return Json(order);
            }
        }

        [Route("Clients/{clientId}/Orders"), HttpPost]
        public IActionResult Create(int clientId, [FromBody] Order order)
        {
            using (var db = new AppDbContext())
            {
                bool clientExists = db.Clients.Where(c => c.ClientId == clientId).Any();
                if (!clientExists) return NotFound();
                order.ClientId = clientId;

                db.Orders.Add(order);
                db.SaveChanges();
                return Json(order);
            }
        }

        [Route("Clients/{clientId}/Orders/{orderId}"), HttpPut]
        public IActionResult Update(int clientId, int orderId, [FromBody] Order orderData)
        {
            using (var db = new AppDbContext())
            {
                var order = db.Orders.Where(o => o.OrderId == orderId).FirstOrDefault();
                if (order == null) return NotFound();
                if (order.ClientId != clientId) return NotFound();




                order.OrderName = orderData.OrderName;
                order.P = orderData.S;
                order.Pipe = orderData.Pipe;
                order.S = orderData.S;
                order.Spot = orderData.Spot;
                order.Angle = orderData.Angle;
                order.Lustra = orderData.Lustra;

                db.SaveChanges();
                return Json(order);
            }
        }

        [Route("Clients/{clientId}/Orders/{orderId}"), HttpDelete]
        public IActionResult Delete(int clientId, int orderId)
        {
            using (var db = new AppDbContext())
            {
                var order = db.Orders.Where(o => o.OrderId == orderId).FirstOrDefault();
                if (order == null) return NotFound();
                if (order.ClientId != clientId) return NotFound();

                db.Orders.Remove(order);
                db.SaveChanges();
                return Ok();
            }
        }
    }
}

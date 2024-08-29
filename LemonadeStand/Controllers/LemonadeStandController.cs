using LemonadeStand.Data;
using LemonadeStand.Entities;
using LemonadeStand.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace LemonadeStand.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LemonadeStandController : ControllerBase
    {
        private readonly LemonadeStandEFCoreDBContext _dbContext;
        public LemonadeStandController(LemonadeStandEFCoreDBContext dbContext)
        {
            _dbContext= dbContext;
        }
        [HttpGet]
        public IActionResult Get()
        {
            ResponseModel response = new ResponseModel();
            try
            {
                var menuItems = _dbContext.Menu.ToList();
                response.Status = true;
                response.Message = "Success";
                response.Data = new { Menu = menuItems };
                return Ok(response);
            }
            catch (Exception ex)
            {
                response.Status = false;
                response.Message = ex.Message;
                return BadRequest(response);
            }

        }

        [HttpPost]
        public IActionResult CreateOrder(CreateOrderViewModel createOrderVM) {
            ResponseModel model = new ResponseModel();
            try
            {
                var createOrder=new Order()
                {
                CustomerName = createOrderVM.CustomerName ,
                CustomerEmail = createOrderVM.CustomerEmail ,
                CustomerPhone = createOrderVM.CustomerPhone 
                };

                _dbContext.Order.Add(createOrder);
                _dbContext.SaveChanges();

                foreach (var item in createOrderVM.OrderedItemsList)
                {
                    var recordOrderItems = new OrderItems()
                    {
                        OrderID = createOrder.Id,
                        MenuItemDescription=item.MenuItemDescription
                    };
                    _dbContext.OrderItems.Add(recordOrderItems);
                    _dbContext.SaveChanges();
                }

                model.Status = true;
                model.Message = "Order Placed";
                model.Data= createOrder;

                return Ok(model);
            }
            catch (Exception ex)
            {
                model.Status = false;
                model.Message = ex.Message;
                return BadRequest(model);
            }

        }
    }
}

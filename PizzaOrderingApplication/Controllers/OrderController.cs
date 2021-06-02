using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using PizzaOrderingApplication.Models;
using PizzaOrderingApplication.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PizzaOrderingApplication.Controllers
{
    public class OrderController : Controller
    {
        private readonly IRepos<OrderDetails> _repos;
        private readonly ILogger<OrderController> _Logger;
        private readonly PizzaContext _Context;

        public OrderController(IRepos<OrderDetails> repos, ILogger<OrderController> logger, PizzaContext Context)
        {
            _repos = repos;
            _Logger = logger;
            _Context = Context;
        }


        /// <summary>
        /// Here the user will see the status of his order.
        /// If he has not orderd then, it will show as no orders has been placed.
        /// </summary>
        /// <returns></returns>
        public IActionResult Index()
        {
            return View();
        }

        /// <summary>
        /// Thsi will take the information of the order.
        /// Frist it will take the information of the person's details.
        /// Second the person or client can choose the type of pizza.
        /// Third block the user will take the information of the crusting type, quantity and slicing to be made.
        /// Finally the user will conforms the order and goes to the status of his order page.
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public IActionResult Order()
        {
            return View();
        }


        [HttpPost]
        public IActionResult Order(OrderDetails order)
        {
            try
            {
                _repos.Add(order);
                return RedirectToAction("Status");
            }
            catch (Exception e)
            {
                _Logger.LogDebug(e.Message);
            }
            return RedirectToAction("Privacy", "Home");
        }

        //This will return to the Status of the order page
        [HttpGet]
        public IActionResult Status()
        {
            try
            {
                //This piece or line of code will fetch the last ordered details.
                var res = _Context.OrderDetails.OrderBy(i => i.OrderId).LastOrDefault();

                string t = res.PizzaName;
                string t2 = res.PizzaName1;
                string t3 = res.PizzaName2;

                var res1 = _Context.PizzaDetails.Where(i => i.PizzaName == t).FirstOrDefault();
                var res2 = _Context.PizzaDetails.Where(i => i.PizzaName == t2).FirstOrDefault();
                var res3 = _Context.PizzaDetails.Where(i => i.PizzaName == t3).FirstOrDefault();

                double price1 = res1.PizzaPrice;
                double price2 = res1.PizzaPrice;
                double price3 = res1.PizzaPrice;

                //Here that records data will be consumed and only one coloum id will be taken and that will be converted to int.
                int id = res.OrderId;

                //Here that id will be consumed and fecthes that paeticular record alone.
                OrderDetails details = _repos.Get(id);

                string s = Convert.ToString(res.Crusting);

                switch (s)
                {
                    case "New hand tosted":
                        ViewBag.Price = price1+10;
                        break;
                    case "Wheat thin crust":
                        ViewBag.Price = price1+15;
                        break;
                    case "Cheese brust":
                        ViewBag.Price = price1+20;
                        break;
                    case "Fresh pan pizza":
                        ViewBag.Price = price1+15;
                        break;
                    default:
                        break;
                }

                int Qty = Convert.ToInt32(res.Quantity);

                ViewBag.FinalPrice = (ViewBag.Price + price2 + price3) * Qty;

                return View(details); 
            }
            catch (Exception e)
            {
                _Logger.LogDebug(e.Message);
            }
            return RedirectToAction("Privacy", "Home");
        }

        public IActionResult ContactUs()
        {
            return View();
        }
    }
}

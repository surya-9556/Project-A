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
    public class VegController : Controller
    {
        private readonly IRepo<PizzaDetails> _repo;
        private readonly PizzaContext _context;
        private readonly ILogger<VegController> _logger;

        public VegController(PizzaContext context, ILogger<VegController> logger, IRepo<PizzaDetails> repo)
        {
            _context = context;
            _logger = logger;
            _repo = repo;
        }

        /// <summary>
        /// Here in this page or controller the data will show the filtered data of Vegetarian pizzas.
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public IActionResult Index()
        {
            try
            {
                var res = _context.PizzaDetails.Where(i => i.PizzaType == "Veg").ToList();
                return View(res);
            }
            catch (Exception e)
            {
                _logger.LogDebug(e.Message);
            }
            return RedirectToAction("Index", "Pizza");
        }

        //Gives the Details of the each and every item.
        [HttpGet]
        public IActionResult DetailsOfPizza(int id)
        {
            try
            {
                PizzaDetails P = _repo.Get(id);
                return View(P);
            }
            catch (Exception e)
            {
                _logger.LogDebug(e.Message);
            }
            return RedirectToAction("Index", "Pizza");
        }
    }
}

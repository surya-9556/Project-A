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
    public class PizzaController : Controller
    {
        private readonly IRepo<PizzaDetails> _repo;
        private readonly ILogger<PizzaController> _logger;

        //Dependancey injection
        public PizzaController(IRepo<PizzaDetails> repo, ILogger<PizzaController> logger)
        {
            _repo = repo;
            _logger = logger;
        }

        /// <summary>
        /// Here you can view all the data of the pizzas i.e., both veg and non-veg pizzas.
        /// </summary>
        /// <returns></returns>
        public IActionResult Index()
        {
            try
            {
                List<PizzaDetails> pizzaDetails = _repo.GetAll().ToList();
                return View(pizzaDetails);
            }
            catch (Exception e)
            {
                _logger.LogDebug(e.Message);
            }
            return RedirectToAction("Privacy", "Home");
        }

        //This cannot be done by the User or client.
        [HttpGet]
        public IActionResult AddPizza()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddPizza(PizzaDetails details)
        {
            try
            {
                _repo.Add(details);
                return RedirectToAction("Index");
            }
            catch (Exception e)
            {
                _logger.LogDebug(e.Message);
            }
            return RedirectToAction("Privacy", "Home");
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
            return RedirectToAction("Privacy", "Home");
        }
    }
}

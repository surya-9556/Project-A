using Microsoft.Extensions.Logging;
using PizzaOrderingApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PizzaOrderingApplication.Services
{
    /// <summary>
    /// In this class i have done the crud operations for ordering.
    /// </summary>
    public class OrderManager : IRepos<OrderDetails>
    {
        PizzaContext _Context;
        ILogger<OrderManager> _Logger;

        public OrderManager(PizzaContext context, ILogger<OrderManager> logger)
        {
            _Context = context;
            _Logger = logger;
        }

        //This will add the order details.
        public void Add(OrderDetails t)
        {
            try
            {
                _Context.OrderDetails.Add(t);
                _Context.SaveChanges();
            }
            catch (Exception e)
            {
                _Logger.LogDebug(e.Message);
            }
        }

        //This will delete the order details but this is not possible because i have not given the option for
        //deleting the record.
        public void Delete(OrderDetails t)
        {
            try
            {
                _Context.OrderDetails.Remove(t);
                _Context.SaveChanges();
            }
            catch (Exception e)
            {
                _Logger.LogDebug(e.Message);
            }
        }

        //This will fetch that particular record with the help of id. 
        //This will help us in getting the details of the order and show to the customer.
        public OrderDetails Get(int id)
        {
            try
            {
                OrderDetails P = _Context.OrderDetails.FirstOrDefault(i => i.OrderId == id);
                return P;
            }
            catch (Exception e)
            {
                _Logger.LogDebug(e.Message);
            }
            return null;
        }

        //This will fetch all the records of the data orders.
        //But i our sinario this method is not necessary.
        //In case, in the future if we want to update the record then this will help a lot.
        public IEnumerable<OrderDetails> GetAll()
        {
            try
            {
                if (_Context.OrderDetails.Count() == 0)
                {
                    return null;
                }
                return _Context.OrderDetails.ToList();
            }
            catch (Exception e)
            {
                _Logger.LogDebug(e.Message);
            }
            return null;
        }
    }
}

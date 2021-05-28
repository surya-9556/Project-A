using Microsoft.Extensions.Logging;
using PizzaOrderingApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PizzaOrderingApplication.Services
{
    /// <summary>
    /// Here i have done the crud operations for the Pizza database.
    /// </summary>
    public class PizzaManager : IRepo<PizzaDetails>
    {
        readonly PizzaContext _context;
        readonly ILogger<PizzaManager> _Logger;

        public PizzaManager(PizzaContext context, ILogger<PizzaManager> logger)
        {
            _context = context;
            _Logger = logger;
        }

        //This will add the data to the data base.
        public void Add(PizzaDetails t)
        {
            try
            {
                _context.PizzaDetails.Add(t);
                _context.SaveChanges();
            }
            catch (Exception e)
            {
                _Logger.LogDebug(e.Message);
            }
        }

        //This will Delete the particular record.
        public void Delete(PizzaDetails t)
        {
            try
            {
                _context.PizzaDetails.Remove(t);
                _context.SaveChanges();
            }
            catch (Exception e)
            {
                _Logger.LogDebug(e.Message);
            }
        }
        
        //This will fetch the particular id's data.
        public PizzaDetails Get(int id)
        {
            try
            {
                PizzaDetails P = _context.PizzaDetails.FirstOrDefault(i => i.PizzaID == id);
                return P;
            }
            catch (Exception e)
            {
                _Logger.LogDebug(e.Message);
            }
            return null;
        }


        //This will fetch all the details.
        public IEnumerable<PizzaDetails> GetAll()
        {
            try
            {
                if (_context.PizzaDetails.Count() == 0)
                {
                    return null;
                }
                return _context.PizzaDetails.ToList();
            }
            catch (Exception e)
            {
                _Logger.LogDebug(e.Message);
            }
            return null;
        }

        //This will update the database of pizza.
        public void Update(int id, PizzaDetails t)
        {
            try
            {
                PizzaDetails P = Get(id);
                if (P != null)
                {
                    P.PizzaName = t.PizzaName;
                    P.PizzaType = t.PizzaType;
                    P.PizzaSecality = t.PizzaSecality;
                    P.PizzaImage = t.PizzaImage;
                    P.PizzaPrice = t.PizzaPrice;
                    P.PizzaSize = t.PizzaSize;
                }
                _context.SaveChanges();
            }
            catch (Exception e)
            {
                _Logger.LogDebug(e.Message);
            }
        }
    }
}

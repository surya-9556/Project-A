using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PizzaOrderingApplication.Services
{
    //This interface is regering to the order details.
    public interface IRepos<T>
    {
        void Add(T t);
        T Get(int id);
        void Delete(T t);
        IEnumerable<T> GetAll();
    }
}

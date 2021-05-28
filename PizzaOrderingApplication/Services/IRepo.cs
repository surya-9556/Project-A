using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PizzaOrderingApplication.Services
{
    //This is the interface where the crud operations will be handeled in organized way.
    //This is for the pizza details repo.
    public interface IRepo<T>
    {
        void Add(T t);
        void Update(int id, T t);
        void Delete(T t);
        IEnumerable<T> GetAll();
        T Get(int id);
    }
}

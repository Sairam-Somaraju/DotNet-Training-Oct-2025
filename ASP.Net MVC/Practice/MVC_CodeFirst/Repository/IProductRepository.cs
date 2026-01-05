using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC_CodeFirst.Repository
{
    public  interface IProductRepository<T> where T:class
    {
        IEnumerable<T> GetAll(); //Get All Products
        T GetByID(int id); // to get a particular Product
        void Insert (T obj);
        void Update (T obj);
        void Delete (object Id);
        void Save();

    }
}

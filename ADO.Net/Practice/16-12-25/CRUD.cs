using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Services;
using System.Text;
using System.Threading.Tasks;

namespace _16_12_25
{
    internal class CRUD
    {
        Model1Container ob=new Model1Container();

        public void AddPizza()
        {
            Pizzas p=new Pizzas()
            {
                PizzaId=101,
                PizzaName="Cheese Non Veg",
                Price=200,
                Description="Made with Cheese",
                Type="Non Veg"
            };
            ob.Pizzas.Add(p);
            int i=ob.SaveChanges();
            Console.WriteLine("Total records inserted: "+i);

            foreach(var item in ob.Pizzas)
            {
                Console.WriteLine($"{item.PizzaId}  {item.PizzaName}  {item.Price}  {item.Description}  {item.Type}");
            }
        }
        public void UpdateRecord()
        {
            Console.WriteLine("Enter the Id: ");
        }
    }
}

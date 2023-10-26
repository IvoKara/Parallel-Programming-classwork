using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Lab2._2
{
    class CustomersList
    {
        public static List<Customer> Customers { get; private set; } = new List<Customer>() { 
            new Customer(1, "Ivo", "Sofia", 4),
            new Customer(2, "Pesho", "Varna", 2),
            new Customer(3, "Alex", "Plovdiv", 3),
            new Customer(4, "Max", "Stara Zagora", 5),
            new Customer(5, "Kristian", "Sofia", 10),
        };

        public static async Task<Customer?> FindById(int id)
        {
            Customer? customer = Customers.Find( c => c.Id == id);
            await Task.Delay(500);
            return customer;
        }

        public static async Task<Customer?[]> FindAllByIds(int[] ids)
        {
            Task<Customer?>[] tasks = new Task<Customer?>[ids.Length];
            for (int i = 0; i < ids.Length; i++)
            {
                tasks[i] = FindById(ids[i]);
                // tasks[i].Start();
            }
            var result = await Task.WhenAll(tasks);
            return result;
        }
    }
}

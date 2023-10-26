using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2._2
{
    class Customer
    {
        public int Id { get; private set; }
        public string Name { get; set; } = string.Empty;
        public string Address { get; set; } = string.Empty;
        public int NumberOfOrders { get; set; } = 0;

        public Customer() { }

        public Customer(int id, string name, string address, int numberOforders)
        {
            Id = id;
            Name = name;
            Address = address;
            NumberOfOrders = numberOforders;
        }

        public override string ToString()
        {
            return $"[Name = {Name}, Address = {Address}, Number of orders = {NumberOfOrders}]";
        }
    }
}

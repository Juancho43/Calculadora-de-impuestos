using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraImpuestos.Model
{
    public class Product
    {
        private int Id { get; set; }
        private string Name { get; set; }
        private decimal Price { get; set; }
        public Product() { }
        public Product(int id, string name, decimal price)
        {
            Id = id;
            Name = name;
            Price = price;
        }
        public decimal GetPrice()
        {
            return Price;
        }
        public override string ToString()
        {
            return Name + " --- $" + Price;
        }
    }
}

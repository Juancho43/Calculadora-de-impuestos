using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraImpuestos.Model
{
    public class Item
    {

        private int Id { get; set; }
        private Product Product {  get; set; }
        private int Quantity { get; set; }

        public Item() { }
        public Item(int id, Product product, int quantity)
        {
            Id = id;
            Product = product;
            Quantity = quantity;
        }
        public Product GetProduct()
        {
            return Product;
        }
        public int GetQuantity()
        {
            return Quantity;
        }
        public override string ToString()
        {
            return $"{Quantity}x {Product}";
        }


    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraImpuestos.Model
{
    public class Order
    {
        private int Id { get; set; }
        private TaxCalculator Calculator { get; set; }
        private List<Item> Items { get; set; }
        private Country Country { get; set; }
        private State State { get; set; }
        private string City { get; set; }

        public Order() { }
        public Order(List<Item> items, Country country, State state, string city)
        {
            Items = items;
            Country = country;
            State = state;
            City = city;
            Calculator = new TaxCalculator();
        }
        
        public decimal GetOrderSubtotal()
        {
            decimal subtotal = 0;
            foreach (Item item in Items)
            {
                subtotal += item.GetProduct().GetPrice() * item.GetQuantity();
            }
            return subtotal;

        }

        public decimal GetOrderTotal()
        {
            decimal total = 0;
            foreach (Item item in Items)
            {
                
                decimal subtotal = item.GetProduct().GetPrice() * item.GetQuantity();
                total += subtotal * Calculator.getTaxRate(Country, State, item.GetProduct());
            }
            return total;
        }

        public decimal GetTotalToPay()
        {
            return GetOrderSubtotal() + GetOrderTotal();
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Order ID: {Id}"); // Assuming Id has a value by this point


            if (Country != null)
            {
                sb.AppendLine($"Country: {Country}");
                if (State != null)
                {
                    sb.AppendLine($"State: {State}");
                }
            }

            if (!string.IsNullOrEmpty(City))
            {
                sb.AppendLine($"City: {City}");
            }

            sb.AppendLine("Items:");
            foreach (Item item in Items)
            {
                sb.AppendLine("#" + item);
            }
            sb.AppendLine($"Subtotal: ${GetOrderSubtotal()}");
            sb.AppendLine($"Taxes: ${GetOrderTotal()}");
            sb.AppendLine($"Total: ${GetTotalToPay()}");
            return sb.ToString();
        }

    }
}

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

        public double getOrderTotal()
        {
            return 0;
        }
    }
}

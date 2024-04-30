using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraImpuestos.Model
{
    public class Tax
    {
        private long Id {  get; set; }
        private string Name { get; set; }
        private decimal Quantity {  get; set; }

        public Tax(long id, string name, decimal quantity) {
            Id = id;
            Name = name;
            Quantity = quantity;
        }

        public decimal GetQuantity()
        {
            return Quantity;
        }
        public override string ToString()
        {
            return Name + ": " + Quantity;
        }
    }
}

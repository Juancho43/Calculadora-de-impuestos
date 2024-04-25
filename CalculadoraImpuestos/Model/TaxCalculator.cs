using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraImpuestos.Model
{
    public class TaxCalculator
    {
        public TaxCalculator() { }
        public double getTaxRate(Country country, State state, Product product)
        {
            return 0;

        }
        private double getUSTax(State state)
        {
            return 0;
        }

        private double getEUTax(Country country) 
        { 
            return 0;
        }

        private double getChineseTax(Product product)
        {
            return 0;
        }

    }
}

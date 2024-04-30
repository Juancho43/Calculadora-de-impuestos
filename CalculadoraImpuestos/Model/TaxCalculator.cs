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
        public decimal getTaxRate(Country country, State state, Product product)
        {
            decimal taxRate = 0;

            switch (country.Short_Name)
            {
                case "USA":
                    taxRate = getUSTax(state);
                    break;
                case "Ch":
                    taxRate = getChineseTax(product);
                    break;
                case "EU":
                     taxRate = getEUTax(country);
                    break;
    
            }
            return taxRate;

        }
        private decimal getUSTax(State state)
        {
            return state.GetTaxQuantity();
        }

        private decimal getEUTax(Country country) 
        { 
            return country.GetTaxQuantity();
        }

        private decimal getChineseTax(Product product)
        {
            return 0;
        }

    }
}

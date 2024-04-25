using CalculadoraImpuestos.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraImpuestos.Static
{
    public static class AppStatic
    {
        static List<Product> products = new List<Product>();
        static List<Country> countries = new List<Country>();
        static List<State> states = new List<State>();

        public static void InstanciarProductos()
        {
            products.Add(new Product(1, "Jamon", 10));
            products.Add(new Product(2, "Paleta", 13));
            products.Add(new Product(1, "Queso parmesano", 18));
            products.Add(new Product(1, "Queso sardo", 16));
        }

        public static void InstanciarPaises()
        {
            countries.Add(new Country(1,"United States","USA",new Tax(1,"IVA",0.07)));
            countries.Add(new Country(2, "Spain","SP", new Tax(2, "IVA", 0.07)));
        }
        public static void InstanciarEstados()
        {
            states.Add(new State(1,"Texas","tx", new Tax(3, "IVA", 0.1), countries[0]));
        }
    }
}

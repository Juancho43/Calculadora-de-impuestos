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
        public static List<Product> products = new List<Product>();
        public static List<Country> countries = new List<Country>();
        public static List<State> states = new List<State>();
        public static List<Order> orders = new List<Order>();

        public static void InstanciarTodo()
        {
            InstanciarProductos();
            InstanciarPaises();
            InstanciarEstados();
            InstanciarOrdenes();
        }


        public static void InstanciarProductos()
        {
            products.Add(new Product(1, "Jamon", 10));
            products.Add(new Product(2, "Paleta", 13));
            products.Add(new Product(3, "Queso parmesano", 18));
            products.Add(new Product(4, "Queso sardo", 16));
            products.Add(new Product(5, "Manzana", 2.5m));
            products.Add(new Product(6, "Leche", 3.75m));
            products.Add(new Product(7, "Pan integral", 4.20m));
            products.Add(new Product(8, "Cafe", 5.99m));
            products.Add(new Product(9, "Camiseta", 15.00m));
            products.Add(new Product(10, "Pantalón", 20.00m));
            products.Add(new Product(11, "Zapatos", 35.00m));
            products.Add(new Product(12, "Libro", 12.50m));
            products.Add(new Product(13, "Boligrafo", 1.50m));
            products.Add(new Product(14, "Computadora", 750.00m));
        }

        public static void InstanciarPaises()
        {
            countries.Add(new Country(1,"United States","USA",new Tax(1,"IVA", (decimal)0.07)));
            countries.Add(new Country(2, "Spain","EU", new Tax(2, "IVA", (decimal)0.21)));
            countries.Add(new Country(3, "Germany", "EU", new Tax(3, "Mehrwertsteuer", (decimal)0.19)));
            countries.Add(new Country(4, "France", "EU", new Tax(4, "TVA", (decimal)0.20)));
            countries.Add(new Country(5, "Italy", "EU", new Tax(5, "IVA", (decimal)0.22)));
            countries.Add(new Country(6, "China", "CN", new Tax(6, "VAT", (decimal)0.13)));
        }
       
        public static void InstanciarEstados()
        {
            states.Add(new State(1, "Texas", "tx", new Tax(3, "IVA", (decimal)0.10), countries[0]));
            states.Add(new State(2, "California", "ca", new Tax(4, "IVA", (decimal)0.095), countries[0]));
            states.Add(new State(3, "Florida", "fl", new Tax(5, "IVA", (decimal)0.07), countries[0]));
            states.Add(new State(4, "Nueva York", "ny", new Tax(6, "IVA", (decimal)0.0895), countries[0]));
            states.Add(new State(5, "Pensilvania", "pa", new Tax(7, "IVA", (decimal)0.06), countries[0]));

        }

        public static void InstanciarOrdenes()
        {
            // Sample orders with various combinations
            orders.Add(new Order(
              new List<Item>()
              {
                new Item(1,products[0], 2), // Jamon (index 0 in products)
                new Item(2,products[2], 1)  // Queso parmesano (index 2 in products)
              },
              countries[0], // Assuming United States (index 0 in countries)
              states[1],   // Assuming California (index 1 in states)
              "Los Angeles"
            ));

            orders.Add(new Order(
              new List<Item>()
              {
                new Item(3,products[5], 3), // Leche (index 5 in products)
                new Item(4,products[8], 2)  // Cafe (index 8 in products)
              },
              countries[1], // Assuming Spain (index 2 in countries)
              null,          // No state provided
              "Barcelona"
            ));

            orders.Add(new Order(
              new List<Item>()
              {
                  new Item(5,products[9], 1), // Camiseta (index 9 in products)
                  new Item(6,products[11], 2) // Zapatos (index 11 in products)
              },
              countries[4], // Assuming Italy (index 4 in countries)
              null,          // No state provided
              "Rome"
            ));

        }


    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraImpuestos.Model
{
    public class State
    {
        private long Id { get; set; }
        private string Name { get; set; }
        private string ShortName { get; set; }
        private Tax Tax { get; set; }

        private Country Country { get; set; }
        public State() { }

        public State(long id, string name, string shortName, Tax tax, Country country)
        {
            Id = id;
            Name = name;
            ShortName = shortName;
            Tax = tax;
            Country = country;
        }
        public override string ToString()
        {
            return "Country : " + Country + "Name : " + Name + "Tax : " + Tax;
        }

    }
}

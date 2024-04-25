using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraImpuestos.Model
{
    public class Country
    {
        private long Id {  get; set; }
        private string Name { get; set; }
        private string ShortName { get; set; }
        private Tax Tax { get; set; }

        public Country(long id, string name, string shortName, Tax tax) {
            Id = id;
            Name = name;
            ShortName = shortName;
            Tax = tax;
        }
        public override string ToString()
        {
            return "Name : " + Name + "Tax : " + Tax;
        }

    }
}

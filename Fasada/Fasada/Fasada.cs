using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fasada
{
    class Fasada1
    {
        Samochod autko;

        public Fasada1(Samochod autko) => this.autko = autko;
        public string getData() => "Dane samochodu: " + this.autko.getMarka() + " " + this.autko.getModel();

    }
}

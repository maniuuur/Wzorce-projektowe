using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Dekorator;
namespace Dekorator
{
    class Chevrolet : Samochod
    {

        public Chevrolet()
        {
            samochod = "Chevrolet";
        }

        public override double cena()
        {
            return 250000;
        }
    }
}
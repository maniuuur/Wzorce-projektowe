using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fasada
{
    class Program
    {
        static void Main(string[] args)
        {
            Samochod autko = new Samochod();
            autko.setMarka("Ford");
            autko.setModel("Focus");

            Console.WriteLine("Dane samochodu: " +autko.getMarka() + " " + autko.getModel());

            Fasada1 f = new Fasada1(autko);
            Console.WriteLine("Dane wyswietlone przez klase fasady");
            Console.WriteLine(f.getData());

            Console.ReadLine();
        }
    }
}

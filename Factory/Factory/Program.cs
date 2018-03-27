using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    class Program
    {
        static void Main(string[] args)
        {
            Gateway factory = null;

            try
            {
                factory = Factory.createObject("Products");

                factory.addItem("Rower");
                factory.addItem("Skuter");
                factory.addItem("Quad");
                factory.addItem("Hulajnoga");

                Console.WriteLine(factory.listItems());

                factory.sortItems(1);
                Console.WriteLine(factory.listItems());
            }

            catch ( Exception ex )
            {
                Console.WriteLine("Błąd! " + ex.ToString());
            }

            Console.ReadLine();
        }
    }
}

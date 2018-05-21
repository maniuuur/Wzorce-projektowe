using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memento
{
    class Program
    {       
        static void Main()
        {
            Originator o = new Originator();
            o.Stan = "Wł.";

            Caretaker c = new Caretaker();
            c.Memento = o.CreateMemento();

            Console.WriteLine("Zmiana stanu");
            o.Stan = "Wył.";

            o.SetMemento(c.Memento);
            Console.ReadKey();
        }
    }  
}

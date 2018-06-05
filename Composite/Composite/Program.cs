using System;
using System.Collections.Generic;


namespace Composite
{
    class MainApp
    {

        static void Main()
        {
            CompositeElement root = new CompositeElement("Obrazek");

            root.Add(new PrimitiveElement("czerwona linia"));
            root.Add(new PrimitiveElement("niebieski okrąg"));
            root.Add(new PrimitiveElement("zielony box"));

            CompositeElement comp = new CompositeElement("dwa okręgi");

            comp.Add(new PrimitiveElement("czarny okrąg"));
            comp.Add(new PrimitiveElement("biały okrąg"));
            root.Add(comp);
            root.Add(new PrimitiveElement("różowy box"));

            PrimitiveElement pe = new PrimitiveElement("żółta linia");

            root.Add(pe);
            root.Remove(pe);
            root.Display(1);

            Console.ReadKey();
        }
    }
}
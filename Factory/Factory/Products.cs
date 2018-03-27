using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    class Products : Gateway
    {
        List<string> list;

        public Products()
        {
            list = new List<string>();
        }

        string Gateway.addItem(String item)
        {
            list.Add(item);

            return "Produkt " + item + " dodany.";
        }

        string Gateway.deleteItem(int indicator)
        {
            list.RemoveAt(indicator);

            return "Produkt " + indicator + " usunięty.";
        }

        string Gateway.listItems()
        {
            foreach (object item in list)
                Console.WriteLine("Produkt: " + item);
            return "";
        }

        void Gateway.sortItems(int seq)
        {
            if (seq == 1)
                list.Sort();
            else
            {
                list.Sort();
                list.Reverse();
            }
        }
    }
}

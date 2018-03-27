using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    class Privileges : Gateway
    {
        List<string> list;

        public Privileges()
        {
            list = new List<string>();
        }

        string Gateway.addItem(String privilege)
        {
            list.Add(privilege);

            return "Przywilej " + privilege + " dodany.";
        }

        string Gateway.deleteItem(int indicator)
        {
            list.RemoveAt(indicator);

            return "Przywilej " + indicator + " usunięty.";
        }

        string Gateway.listItems()
        {
            foreach (object privilege in list)
                Console.WriteLine("Przywilej: " + privilege);
            return "";
        }

        void Gateway.sortItems(int seq)
        {
            if (seq == 0)
                list.Sort();
            else
            {
                list.Sort();
                list.Reverse();
            }
        }
    }
}

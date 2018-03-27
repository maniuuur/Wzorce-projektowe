using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    class Users : Gateway
    {
        List<string> list;

        public Users()
        {
            list = new List<string>();
        }

        string Gateway.addItem(String user)
        {
            list.Add(user);

            return "Użytkownik " + user + " dodany.";
        }

        string Gateway.deleteItem(int indicator)
        {
            list.RemoveAt(indicator);

            return "Użytkownik " + indicator + " usunięty.";
        }

        string Gateway.listItems()
        {
            foreach (object user in list)
                Console.WriteLine("Użytkownik: " + user);
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

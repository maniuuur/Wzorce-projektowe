using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    interface Gateway
    {
        String addItem(String item);
        String deleteItem(int indicator);
        String listItems();
        void sortItems(int seq);
    }   
}

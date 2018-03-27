using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    public class Factory
    {
        public static Gateway createObject(string name)
        {
            Gateway gateway = null;
            try
            {
                if (name.Equals("Products"))
                    return new Products();

                if (name.Equals("Users"))
                    return new Users();

                if (name.Equals("Privileges"))
                    return new Privileges();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Nie udało się stowrzyć objektu" + ex.ToString());
            }
            return gateway;
        }
    }
}

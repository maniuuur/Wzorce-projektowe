using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    public class Factory : Gateway
    {
        public static Gateway getObject(string name)
        {
            try
            {
                if (name.Equals("Products"))
                    return new Products();
                if (name.Equals("Users"))
                    return new Users();
                if (name.Equals("Privileges"))
                    return new Privileges();
            }
            catch ( Exception ex )
            {
                Console.WriteLine("Nie udało się stowrzyć objektu");
            }
        }
    }
}

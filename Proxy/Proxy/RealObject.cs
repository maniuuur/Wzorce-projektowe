using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy
{
    class RealObject : Object
    {
        public override void Request()
        {
            Console.WriteLine("Wywolanie RealObject.Request()");
        }
    }
}

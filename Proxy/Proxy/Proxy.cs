using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy
{
    class Proxy : Object
    {
        private RealObject _realObject;

        public override void Request()
        {
            if (_realObject == null)
            {
                _realObject = new RealObject();
            }

            _realObject.Request();
        }
    }
}

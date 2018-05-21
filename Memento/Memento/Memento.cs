using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memento
{
    class Memento
    {
        private string _stan;

        public Memento(string stan)
        {
            this._stan = stan;
        }

        public string Stan
        {
            get
            {
                return _stan;
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memento
{
    class Originator
    {
        private string _stan;

        public string Stan
        {
            get
            {
                return _stan;
            }

            set
            {
                _stan = value;

                Console.WriteLine("Stan = " + _stan);
            }
        }

        public Memento CreateMemento()
        {
            return (new Memento(_stan));
        }   

        public void SetMemento(Memento memento)
        {
            Console.WriteLine("Przywracanie stanu");

            Stan = memento.Stan;
        }
    }
}
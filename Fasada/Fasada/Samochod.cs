using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fasada
{
    class Samochod
    {
        private string marka;
        private string model;

        public void setMarka(string marka) => this.marka = marka;
        public void setModel(string model) => this.model = model;
        public string getMarka() => this.marka;
        public string getModel() => this.model;
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chain_of_Responsibility
{
    class MainApp
    {
        static void Main()
        {
            Approver h1 = new Director1();
            Approver h2 = new Director2();
            Approver h3 = new Director3();

            h1.SetSuccessor(h2);
            h2.SetSuccessor(h3);

            int[] requests = { 3, 17, 8, 25, 1, 16, 22, 10 };

            foreach (int request in requests)
            {
                h1.HandleRequest(request);
            }

            Console.ReadKey();
        }
    }

    abstract class Approver
    {
        protected Approver successor;

        public void SetSuccessor(Approver successor)
        {
            this.successor = successor;
        }

        public abstract void HandleRequest(int request);
    }

    class Director1 : Approver
    {
        public override void HandleRequest(int request)

        {
            if (request >= 0 && request < 10)
            {
                Console.WriteLine("{0} handled request {1}\n",
                  this.GetType().Name, request);
            }

            else if (successor != null)
            {
                successor.HandleRequest(request);
            }
        }
    }

    class Director2 : Approver
    {
        public override void HandleRequest(int request)
        {
            if (request >= 10 && request < 20)
            {
                Console.WriteLine("{0} handled request {1}\n",
                  this.GetType().Name, request);
            }

            else if (successor != null)
            {
                successor.HandleRequest(request);
            }
        }
    }

    class Director3 : Approver
    {
        public override void HandleRequest(int request)
        {
            if (request >= 20 && request < 30)
            {
                Console.WriteLine("{0} handled request {1}\n",
                  this.GetType().Name, request);
            }

            else if (successor != null)
            {
                successor.HandleRequest(request);
            }
        }
    }
}


using System;
using System.Collections.Generic;

namespace SingletonList
{
    public class ListaSingleton
    {
        protected List<int> lista = new List<int>();
        protected static ListaSingleton instance = null;

        public static ListaSingleton GetInstance()
        {
            if (instance == null)
                instance = new ListaSingleton();

            return instance;
        }

        public void Wyswielt()
        {
            Console.Write("\n");

            foreach (object element in lista)
                Console.Write(element + ", ");
        }

        public void Dodaj(int element)
        {
            lista.Add(element);
        }

        public void Usun(int index)
        {
            lista.RemoveAt(index);
        }

        public int Ile()
        {
            return lista.Count;
        }

    }
    class Singleton
    {
        static void Main(string[] args)
        {
            ListaSingleton lista1 = ListaSingleton.GetInstance();

            lista1.Dodaj(5);
            lista1.Dodaj(1);
            lista1.Dodaj(3);
            lista1.Dodaj(6);
            lista1.Ile();
            lista1.Wyswielt();

            ListaSingleton lista2 = ListaSingleton.GetInstance();

            lista1.Usun(lista1.Ile()-1);
            
            lista2.Wyswielt();
            Console.ReadLine();
        }
    }
}

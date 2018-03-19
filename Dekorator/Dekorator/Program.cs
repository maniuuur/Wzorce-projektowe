using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Dekorator{

    abstract class Samochod{
        protected string samochod = "Samochod podstawowy";

        virtual public String info(){
            return samochod;
        }

        public abstract double cena();
    }

    abstract class Dekorator : Samochod{
        public abstract override String info();
    }
   
    class Chevrolet : Samochod{

        public Chevrolet(){
            samochod = "Chevrolet";
        }

        public override double cena(){
            return 250000;
        }
    }

    class Nissan : Samochod{

        public Nissan(){
            samochod = "Nissan";
        }

        public override double cena(){
            return 200000;
        }
    }

    class Ford : Samochod{

        public Ford(){
            samochod = "Ford";
        }

        public override double cena(){
            return 150000;
        }
    }

    class Klimatyzacja : Dekorator{
        Samochod auto;

        public Klimatyzacja(Samochod samochod){
            auto = samochod;
        }

        public override String info(){
            return auto.info() + " + klimatyzacja";
        }

        public override double cena(){
            if (auto is Chevrolet){
                return auto.cena() + 10000;
            }
            else if (auto is Nissan){
                return auto.cena() + 12000;
            }
            else if (auto is Ford){
                return auto.cena() + 9000;
            }
            return 0;
        }
    }

    class ElektryczneSzyby : Dekorator{
            Samochod auto;

        public ElektryczneSzyby(Samochod samochod){
            auto = samochod;
        }

        public override String info(){
            return auto.info() + " + elektryczne szyby";
        }
        
        public override double cena(){
            return auto.cena() + 5600;
        }
    }


    public class Program{
        public static void Main(String[] args){

            Samochod autko1 = new Chevrolet();
            Samochod autko2 = new Nissan();
            Samochod autko3 = new Ford();

            Console.WriteLine(">>> DEKORATOR <<<");
            Console.WriteLine("> Samochody z podstawowym wyposazeniem");
            Console.WriteLine(autko1.info() + " " + autko1.cena());
            Console.WriteLine(autko2.info() + " " + autko2.cena());
            Console.WriteLine(autko3.info() + " " + autko3.cena());

            // Przykłady
            autko2 = new Klimatyzacja(autko2);
            Console.WriteLine("\n> Nissan z klimatyzacja");
            Console.WriteLine(autko2.info() + " " + autko2.cena());    

            autko1 = new ElektryczneSzyby(autko1);
            Console.WriteLine("\n> Chevrolet z elektrycznymi szybami");
            Console.WriteLine(autko1.info() + " " + autko1.cena());           
           
            Console.WriteLine("\n> Samochod z pelnym wyposazeniem");
            Samochod autko4 = new ElektryczneSzyby(new Klimatyzacja(new Ford()));
            Console.WriteLine(autko4.info() + " " + autko4.cena());
            Console.ReadLine();
        }
    }
}
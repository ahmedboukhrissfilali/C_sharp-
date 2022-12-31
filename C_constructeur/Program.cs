using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_constructeur
{
    internal class Program
    {
        static void Main(string[] args)
        {
            car car1 = new car("vw","caddy" , 2002,"familly",20000);


            car1.aff();
            Console.ReadKey();
        }
    }
     public class car
    {
        string marque;
        string model;
        int annes;
        string type;
        int km;
        public car(string marque, string model, int annes, string type, int km)
        {
            this.marque = marque;
            this.model = model;
            this.annes = annes;
            this.type = type;
            this.km = km;
        }
        public void aff()
        {
            Console.WriteLine($"your car is {marque} \n model is  : {model} \n years : {annes} \n type is  : {type} \n  km : {km}");
        }
    }
}

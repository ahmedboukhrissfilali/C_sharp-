using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Message
    {
         public static void affichier(string x)
         {
            Console.WriteLine($"your name is {x.ToLower()}");
          }
       public  static void waitting(string name)
        {
            Console.WriteLine($"hi ! {name.ToUpper()} wait please !");
        }
        public static void by(string name)
        {
            Console.WriteLine($"{name.ToUpper()} thank you for visitd");
        }
    }
}

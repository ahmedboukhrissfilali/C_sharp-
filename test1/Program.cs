using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Me p1 = new Me(name,age);

            Console.WriteLine("veuillez entre votre nom ");
            string name = Console.ReadLine();



           Console.WriteLine("veuillez entre votre age ");
            int age = int.Parse(Console.ReadLine());
          

            Console.ReadKey();
        }

    }
    class Me
    {
       public string name;
        public int age;
        public  Me(string name, int age)
         {
            this.name = name;
            this.age = age;

         }

         public void eat()
        {
            Console.WriteLine(name + " is eatig");
        }
         public void sleep()
        {
            Console.WriteLine(name + "is sleeping");
        }
        public void type()
        {
            if(age >10 )
            {
                Console.WriteLine("vous etre petite");
            }
            else if(age <16 ) 
            {
                Console.WriteLine("vous etre minneur");
            }
            else
            {
                Console.WriteLine("vous etre mageur");
            }

        }
    }
}

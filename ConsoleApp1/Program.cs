using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("veuillez entre votre name : ");
                string name = Console.ReadLine();
                Console.WriteLine("veuillez choisir  le numero ");
                Console.WriteLine("1 : dit salut  \n 2 : dit je vous attent  \n 3 : dit aurevoir ");
                int chois = int.Parse(Console.ReadLine());
                switch (chois)
                {
                    case 1:
                        Message.affichier(name);
                        break;
                    case 2:
                        Message.waitting(name);
                        break;
                    case 3:
                        Message.by(name);
                        break;

                        
                };
               
                
            } catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
            Console.ReadKey();


        }
    }
   
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Donnez une mot : ");
            string x = Console.ReadLine();
            int[] Ta = new int[5];
            int N = x.Length;
            for (int i = 0; i < N; i++)
            {
                switch (x[i])
                {
                    case ('a'):
                        Ta[0]++;
                        break;
                    case 'A':
                        Ta[0]++;
                        break;
                    case 'e':
                        Ta[1]++;
                        break;
                    case 'E':
                        Ta[1]++;
                        break;
                    case 'i':
                        Ta[2]++;
                        break;
                    case 'I':
                        Ta[2]++;
                        break;
                    case 'o':
                        Ta[3]++;
                        break;
                    case 'O':
                        Ta[3]++;
                        break;
                    case 'u':
                        Ta[4]++;
                        break;
                    case 'U':
                        Ta[4]++;
                        break;
                    case 'y':
                        Ta[5]++;
                        break;
                    case 'Y':
                        Ta[5]++;
                        break;
                }
            }
            Console.WriteLine($"{Ta[0]} fois la lettre a");
            Console.WriteLine($"{Ta[1]} fois la lettre e");
            Console.WriteLine($"{Ta[2]} fois la lettre i");
            Console.WriteLine($"{Ta[3]} fois la lettre o");
            Console.WriteLine($"{Ta[4]} fois la lettre u");
            Console.WriteLine($"{Ta[4]} fois la lettre Y");
            Console.ReadKey();

        }
    }
    
}

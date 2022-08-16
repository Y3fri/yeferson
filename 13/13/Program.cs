using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int opcion;
            Console.WriteLine("Digite un numero del 1 al 7");
            opcion = Convert.ToInt32(Console.ReadLine());   
            
            switch (opcion)
            {
                case 1:
                    Console.WriteLine("Do");
                    break;
                case 2:
                    Console.WriteLine("Re");
                    break;
                case 3:
                    Console.WriteLine("Mi");
                    break;
                case 4:
                    Console.WriteLine("Fa");
                    break;
                case 5:
                    Console.WriteLine("Sol");
                    break;
                case 6:
                    Console.WriteLine("La");
                    break;
                case 7:
                    Console.WriteLine("Si");
                    break;
                default: Console.WriteLine("no existe");
                    break;
            }
            Console.ReadLine();

        }
    }
}

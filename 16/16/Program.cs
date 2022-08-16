using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a;

            Console.WriteLine("Digite un numero ");
            a = Convert.ToInt32(Console.ReadLine());    

            if(a % 2 == 0)
            {
                Console.WriteLine("Es par");
            }else
            { Console.WriteLine("Es impar");
            }
            Console.ReadLine();
        }
    }
}

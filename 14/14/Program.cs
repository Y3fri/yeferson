using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a;

            Console.WriteLine("Digite un numero ");
            a= Convert.ToInt32(Console.ReadLine()); 

            for(int i = 0; i <= a; i++)
            {
                Console.WriteLine(i);
            }
            Console.ReadLine();
        }
    }
}

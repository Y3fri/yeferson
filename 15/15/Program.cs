using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a; 
            Console.WriteLine("Digite un numero ");
            a = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i <= a; i=i+3)
            {
                Console.WriteLine(i);
            }
            Console.ReadLine();
        
    }
    }
}

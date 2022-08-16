using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n, b=1, suma=0, a;
            Console.WriteLine("Digite un numero ");
            n = Convert.ToInt32(Console.ReadLine());    
            while(suma<=n)
            {
                    a = suma;
                    Console.WriteLine(a);
                    suma = +b;
                    b = a + suma;
               
         
            }
        Console.ReadLine();
             
        }
    }
}

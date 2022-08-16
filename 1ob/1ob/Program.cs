using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1ob
{
    internal class Program
    {   
        public static void Main(string[] args)
        {   
            string nombre;
            int edad;
            
            persona p1=new persona();
                        
            Console.WriteLine("Escriba su nombre: ");
            nombre= Convert.ToString(Console.ReadLine());
            Console.WriteLine("Escriba su edad: ");
            edad = Convert.ToInt32(Console.ReadLine());
            p1.Name = nombre;
            p1.Edad = edad;      
            p1.obtener();
            Console.WriteLine("Su nombre es: "+p1.Name);
            Console.WriteLine("Su Edad es: " + p1.Edad);
           

            Console.ReadLine();
        }
    }
}

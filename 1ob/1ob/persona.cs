using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1ob
{
    internal class persona
    {
        string name;
        int edad;
        int extra;
        

        public persona()
        {
        }

        public persona(string name, int edad)
        {
            this.Name = name;
            this.Edad = edad;
            
        }

        public string Name { get => name; set => name = value; }
        public int Edad { get => edad; set => edad = value; } 
        
      
        public double obtener()
        {
            double sueldo = 500;
            Console.WriteLine("horas extra: ");
            extra = Convert.ToInt32(Console.ReadLine());
            if (extra < 0)
            {
                Console.WriteLine("Su sueldo es: "+sueldo);
            }
            else
            {
                for (int i = 0; i < extra; i++)
                {
                    sueldo = sueldo + 100;
                    
                }Console.WriteLine("Su sueldo es: "+sueldo);
            }
                return sueldo;
        }             
            
        } 
    }
   


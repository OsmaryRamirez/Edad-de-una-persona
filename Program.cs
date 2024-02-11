using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace edad_de_una_persona
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("indroduzca la edad de la persona:    ");
            int edad= Convert.ToInt32 (Console.ReadLine());
            
            // determina si es mayor o menor

            if(edad>=18)
            {
                Console.WriteLine("es mayor de edad.   ");

            }
            else
            {
                Console.WriteLine("ES MENOR DE EDAD.. CUIDATE ");
            }

            Console.WriteLine("Programa terminado");

            
        }

    }
}

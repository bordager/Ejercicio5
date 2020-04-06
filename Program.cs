using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio5
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Introduzca un numero de 5 cifras");
            string numero;
            numero = Console.ReadLine();
                
            if (numero.Length == 5)
            {
                string letra1 = numero.Substring(numero.Length - 1, 1);
                string letra2 = numero.Substring(numero.Length - 2, 1);
                string letra3 = numero.Substring(numero.Length - 3, 1);
                string letra4 = numero.Substring(numero.Length - 4, 1);
                string letra5 = numero.Substring(numero.Length - 5, 1);
                Console.WriteLine("El numero invertido es " + letra1 + letra2 + letra3 + letra4 + letra5);
            }

            else {
                Console.WriteLine("El no es de cinco cifras");
                    }

            Console.Read();
            

        }

        

    }
    
    
    
}
using System;

namespace Unidad2OrtizProfumieriUnzaga
{
    class Program
    {
        static void Main(string[] args)
        {
            PuntoDos();
            //PuntoTres();

        }


        static void PuntoDos()
        {
            /*
             Hacer un programa que le pida al usuario que ingrese un número 
             y le responda si es divisible por 4.
            */

            int userNumber;
            double divisionRest;

            userNumber = NumeroValidacion("Ingresa un número para saber si es divisible por 4: ");
            divisionRest = userNumber % 4;
            
            if (divisionRest == 0)
            {
                Console.WriteLine($"el número {userNumber} es divisible por 4");
            }
            else if (divisionRest != 0)
            {
                Console.WriteLine($"el número {userNumber} NO es divisible por 4");
            }
        }
        private static void PuntoTres()
        {
            /*
             * Hacer un programa que le pida al usuario que ingrese dos números, 
             * luego los compare y muestre si el primer numero es mayor, igual o 
             * menor que el segundo.
             */
            int firstNumber;
            int secondNumber;
            Console.WriteLine("ingrese el primer número");
            firstNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("ingrese el segundo número");
            secondNumber = Convert.ToInt32(Console.ReadLine());
            if (firstNumber > secondNumber)
            {
                Console.WriteLine("el primer número es mayor que el segundo");
            }
            else if (firstNumber < secondNumber)
            {
                Console.WriteLine("el segundo número es mayor que el segundo");
            }
            else if (secondNumber == firstNumber)
            {

                Console.WriteLine("los números son iguales");

            }

        }
        //Punto 6
        public static byte NumeroValidacion(string mensaje, byte min = byte.MinValue, byte max = byte.MaxValue)
        {
            byte numero;
            bool flag;

            do
            {
                Console.Write(mensaje);
                string entrada = Console.ReadLine();
                flag = byte.TryParse(entrada, out numero) && numero >= min && numero <= max;

                if (!flag)
                {
                    Console.WriteLine("Error: Ingrese un número válido.");
                }

            } while (!flag);

            return numero;
        }
    }
}








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

            int number;
            int num;
            string userNumber="";
            double divisionRest;
            Console.WriteLine("ingresa un número");
            userNumber = Console.ReadLine();
            while (userNumber=="")
            {
                if (int.TryParse(userNumber, out num))
                {
                    number = Convert.ToInt32(userNumber);
                    divisionRest = number % 4;
                    if (divisionRest == 0)
                    {
                        Console.WriteLine("el número es divisible por 4");
                    }
                    else if (divisionRest != 0)
                    {
                        Console.WriteLine("el número NO es divisible por 4");
                    }
                }
                else
                {
                    Console.WriteLine("caracter incorrecto");
                    userNumber = "";
                }
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
    }
}








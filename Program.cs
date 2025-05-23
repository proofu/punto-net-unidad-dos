﻿using System;

namespace Unidad2OrtizProfumieriUnzaga
{
    class Program
    {
        static void Main(string[] args)
        {
            PuntoDos();
            PuntoTres();
            PuntoCuatro();
            PuntoCinco();
        }


        static void PuntoDos()
        {
            int numeroUsuario;
            double restoDivision;

            numeroUsuario = NumeroValidacion("Ingresa un número para saber si es divisible por 4: ");
            restoDivision = numeroUsuario % 4;
            
            if (restoDivision == 0)
            {
                Console.WriteLine($"el número {numeroUsuario} es divisible por 4");
            }
            else if (restoDivision != 0)
            {
                Console.WriteLine($"el número {numeroUsuario} NO es divisible por 4");
            }
        }
        private static void PuntoTres()
        {
            int primerNumero;
            int segundoNumero;
            primerNumero = NumeroValidacion("ingrese el primer número para realizar la comparativa: ");
            segundoNumero = NumeroValidacion("ingrese el segundo número: ");

            if (primerNumero > segundoNumero)
            {
                Console.WriteLine("el primer número es mayor que el segundo");
            }
            else if (primerNumero < segundoNumero)
            {
                Console.WriteLine("el segundo número es mayor que el primero");
            }
            else if (segundoNumero == primerNumero)
            {

                Console.WriteLine("los números son iguales");

            }

        }
        private static void PuntoCuatro()
        {
            int mesNumero = NumeroValidacion("Ingrese un número del 1 al 12 para saber el mes correspondiente: ", 1, 12);

            switch (mesNumero)
            {
                case 1: Console.WriteLine("Enero"); break;
                case 2: Console.WriteLine("Febrero"); break;
                case 3: Console.WriteLine("Marzo"); break;
                case 4: Console.WriteLine("Abril"); break;
                case 5: Console.WriteLine("Mayo"); break;
                case 6: Console.WriteLine("Junio"); break;
                case 7: Console.WriteLine("Julio"); break;
                case 8: Console.WriteLine("Agosto"); break;
                case 9: Console.WriteLine("Septiembre"); break;
                case 10: Console.WriteLine("Octubre"); break;
                case 11: Console.WriteLine("Noviembre"); break;
                case 12: Console.WriteLine("Diciembre"); break;
            }
        }

        private static void PuntoCinco()
        {
            int numeroTabla = NumeroValidacion("Ingrese un número para mostrar su tabla de multiplicar del 1 al 10: ");

            Console.WriteLine($"Tabla de multiplicar del {numeroTabla}:");
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"{numeroTabla} x {i} = {numeroTabla * i}");
            }
            Console.ReadLine();
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








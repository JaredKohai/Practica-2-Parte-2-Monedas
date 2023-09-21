using System;
using System.Globalization;

namespace Practica_2_Parte_2
{
    //La tarea revisada, mencione que no tenía luz para subirlo, pero ya tengo y cambie unas cositas
    class Program
    {
        static void Main()
        {
            bool continuar = true;

            while (continuar)
            {
                try
                {
                    Console.Clear();
                    Console.Write("Ingrese el precio: ");
                    decimal precio = ParseDecimal(Console.ReadLine());
                    Console.Write("Ingrese la cantidad pagada: ");
                    decimal cantidadPagada = ParseDecimal(Console.ReadLine());

                    if(cantidadPagada < precio)
                    {
                        Console.WriteLine("");
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Debes dinero");
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                    else
                    {

                    CambioCalculator calculator = new CambioCalculator();
                    Cambio cambio = calculator.CalcularCambio(precio, cantidadPagada);
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("\nCambio:");
                    cambio.MostrarCambio();
                    Console.ForegroundColor = ConsoleColor.White;
                    }
    
                }
                catch (Exception ex)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"Error: {ex.Message}, presiona para reiniciar");
                    Console.ReadLine();
                    Console.ForegroundColor = ConsoleColor.White;
                }

                Console.WriteLine("\n¿Desea calcular otro cambio? \n1 = Si");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Presione otra tecla para salir ");
                string respuesta = Console.ReadLine();
                Console.ForegroundColor = ConsoleColor.White;
                if (respuesta != "1")
                {
                    continuar = false;
                }
                else
                {

                }
            }
        }
        static decimal ParseDecimal(string input)
        {
            input = input.Replace(',', '.');
            return decimal.Parse(input, CultureInfo.InvariantCulture);
        }
    }


}


using System;

namespace exercicio4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Temperatura em Celsius: ");
            double celsius = double.Parse(Console.ReadLine());
            double f = (9 * celsius + 160) / 5;
            Console.WriteLine(f + " Fahrenheit");
            
        }
    }
}
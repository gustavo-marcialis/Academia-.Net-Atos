using System.Runtime.Serialization.Formatters;

namespace idadevalida
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int idade, i;

            for (i = 0; true; i++)
            {
                Console.Write("digite sua idade: ");
                idade = int.Parse(Console.ReadLine());

                if (idade >0)
                {
                    Console.WriteLine("Sua idade é: " + idade + " anos");
                    break;
                }
            }
        }
    }
}
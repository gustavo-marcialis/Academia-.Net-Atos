using System.Globalization;

namespace matriz_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] matriz = new int[5, 3];

            // i = linha
            //j = coluna

            for (int i = 0; i < 5; i++)
            {
                Console.Write("Digite um valor para a primeira coluna: ");
                matriz[i, 0] = int.Parse(Console.ReadLine());
                matriz[i, 1] = matriz[i, 0] + 10;
                matriz[i, 2] = matriz[i, 0] * 2;
            }

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(matriz[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }
    }
}
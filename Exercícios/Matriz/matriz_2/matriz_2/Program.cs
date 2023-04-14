using System.Xml;

namespace matriz_2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //i = linha
            //j = coluna

            int[,] matriz = new int[3, 3];
            int soma;

            Console.WriteLine("linhas: " + matriz.GetLength(0));
            Console.WriteLine("colunas: " + matriz.GetLength(1));

            Console.WriteLine("\n Preencha a matriz 2x3!!");

            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    Console.Write("Posição [" + (i+1) + "," + (j + 1) + "]: ");
                    matriz[i, j] = int.Parse(Console.ReadLine());
                }
            }

            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    Console.Write(matriz[i, j] + "\t");
                }
                Console.WriteLine();
            }


            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                soma = 0;
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    soma = soma + matriz[i, j];
                }
                Console.WriteLine("A soma dos elementos da linha " + (i + 1) + ": " + soma);
            }


            for (int j = 0; j < matriz.GetLength(1); j++)
            {
                soma = 0;
                for (int i = 0; i < matriz.GetLength(0); i++)
                {
                    soma = soma + matriz[i, j];
                }
                Console.WriteLine("A soma dos elementos da coluna " + (j + 1) + ": " + soma);
            }
        }
    }
}
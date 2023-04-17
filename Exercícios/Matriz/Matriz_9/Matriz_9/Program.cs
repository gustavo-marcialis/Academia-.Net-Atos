using System;

namespace Matriz_9
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] matriz = new int[3, 3];
            int numero;

            Console.WriteLine("Digite os valores da matriz:\n");

            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(0); j++)
                {
                    Console.Write($"Posição [{i + 1}, {j + 1}]: ");
                    matriz[i, j] = int.Parse(Console.ReadLine());
                }
            }

            Console.Write("\n Digite um número para pesquisar na matriz: ");
            numero = int.Parse(Console.ReadLine());

            bool encontrado = false;

            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(0); j++)
                {
                    if (matriz[i, j] == numero)
                    {
                        encontrado = true;
                        break;
                    }
                }

                if (encontrado)
                {
                    break;
                }
            }

            if (encontrado)
            {
                Console.WriteLine("\n O número existe na matriz.");
            }
            else
            {
                Console.WriteLine("\n Número inexistente na matriz.");
            }
        }
    }
}
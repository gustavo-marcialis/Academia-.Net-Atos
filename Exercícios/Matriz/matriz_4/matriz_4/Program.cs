namespace matriz_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //i = linhas
            //j = colunas

            int[,] matriz = new int[5, 5];
            int pares = 0, impares = 0, zeros = 0, positivos = 0, negativos = 0;

            Console.WriteLine("\n Preencha a matriz 5x5!!");

            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    Console.Write("Posição [" + (i + 1) + "," + (j + 1) + "]: ");
                    matriz[i, j] = int.Parse(Console.ReadLine());

                    if (matriz[i, j] > 0 && matriz[i, j] % 2 == 0)
                    {
                        pares += 1;

                        if (matriz[i, j] > 0)
                        {
                            positivos += 1;
                        }
                    }
                    else if (matriz[i, j] > 0 && matriz[i, j] % 2 != 0)
                    {
                        impares += 1;

                        if (matriz[i, j] > 0)
                        {
                            positivos += 1;
                        }
                    }


                    else if (matriz[i, j] < 0)
                    {
                        negativos += 1;
                    }

                    else if (matriz[i, j] == 0)
                    {
                        zeros += 1;
                    }
                }
            }

            Console.WriteLine("Pares: " + pares);
            Console.WriteLine("Ímpares: " + impares);
            Console.WriteLine("Positivos: " + positivos);
            Console.WriteLine("Negativos: " + negativos);
            Console.WriteLine("Zeros: " + zeros);

        }
    }
}
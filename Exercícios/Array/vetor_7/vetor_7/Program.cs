namespace vetor_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] vetor = new int[10];
            int[] pares = new int[10];
            int[] impares = new int[10];
            int contadorPares = 0;
            int contadorImpares = 0;

            for (int i = 0; i < 10; i++)
            {
                Console.Write($"Digite o {i + 1}º número inteiro: ");
                vetor[i] = int.Parse(Console.ReadLine());

                if (vetor[i] % 2 == 0)
                {
                    pares[contadorPares] = vetor[i];
                    contadorPares++;
                }
                else
                {
                    impares[contadorImpares] = vetor[i];
                    contadorImpares++;
                }
            }

            Console.Write("Números pares lidos: ");
            for (int i = 0; i < contadorPares; i++)
            {
                Console.Write($"{pares[i]} ");
            }

            Console.Write("\nNúmeros ímpares lidos: ");
            for (int i = 0; i < contadorImpares; i++)
            {
                Console.Write($"{impares[i]} ");
            }
        }
    }
}
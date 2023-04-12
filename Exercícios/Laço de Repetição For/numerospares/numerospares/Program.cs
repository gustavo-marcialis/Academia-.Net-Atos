namespace numerospares
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i, soma;
            soma = 0;

            for (i = 1; i <= 500; i++)
            { 
                if (i % 2 == 0)
                {
                    soma += i;
                }
            }
            Console.WriteLine("A soma de todos os números pares entre 1 e 500 é: " + soma);
        }
    }
}
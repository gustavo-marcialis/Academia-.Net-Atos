namespace fatorial
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int resultado, i, fatorial;

            Console.Write("Digite um número: ");
            fatorial = int.Parse(Console.ReadLine());

            resultado = 1;

            for (i = fatorial; i >= 1; i--)
            {
                resultado = resultado * i;
            }
            Console.WriteLine("Fatorial de " + fatorial + " é: " + resultado);
        }

    }
}
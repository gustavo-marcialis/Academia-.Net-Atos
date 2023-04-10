namespace for_tabuada
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i, tabuada, resultado;

            Console.Write("Digite a tabuada desejada: ");
            tabuada = int.Parse(Console.ReadLine());

            for (i = 1; i <= 10; i++ )
            {
                resultado = i*tabuada;
                Console.WriteLine(tabuada + "x" + i + " = " + resultado);
            }
        }
    }
}
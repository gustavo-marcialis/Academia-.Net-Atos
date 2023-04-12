namespace while_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int idade;

            do
            {
                Console.Write("Digite sua idade: ");
                idade = int.Parse(Console.ReadLine());

            } while (idade <= 0);
            Console.WriteLine("idade válida: " + idade);
        }
    }
}
namespace if_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite uma frase: ");
            string frase = Console.ReadLine();

            Console.Write("Digite a palavra a ser buscada: ");
            string palavra = Console.ReadLine();

            if (frase.Contains(palavra))
            {
                Console.WriteLine("A palavra encontra-se na frase.");
            }
            else
            {
                Console.WriteLine("A palavra não se encontra na frase.");
            }
        }
    }
}
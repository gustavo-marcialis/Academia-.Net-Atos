namespace vetor_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] n = new int[20];

            for (int i = 0; i < n.Length; i++)
            {
                Console.Write($"Digite o {i + 1}º número: ");
                n[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("\n ORDEM NORMAL");
            for (int i = 0; i < n.Length; i++)
            {
                Console.Write($"{n[i]} ");
            }

            Console.WriteLine("\n ORDEM INVERSA");
            for (int i = n.Length - 1; i >= 0; i--)
            {
                Console.Write($"{n[i]} ");
            }
        }
    }
}
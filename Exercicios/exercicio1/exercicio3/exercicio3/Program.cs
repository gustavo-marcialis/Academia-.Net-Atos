namespace exercicio3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 5;
            int b = 6;
            int troca;

            troca = a;
            a = b;
            b = troca;

            Console.WriteLine("a: " + a);
            Console.WriteLine("b: " + b);

            
        }
    }
}
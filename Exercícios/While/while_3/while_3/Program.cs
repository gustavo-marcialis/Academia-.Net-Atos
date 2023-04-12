namespace while_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n;
            string op;

            while (true)
            {
                Console.Write("Digite um Número: ");
                
                n = int.Parse((Console.ReadLine()));

                if (n <= 0)
                {
                    continue;
                }
                else
                {
                    if (n % 2 == 0)
                    {
                        Console.WriteLine("PAR!");
                        Console.Write("deseja digitar outro número? s/n: ");
                        op = Console.ReadLine();

                        if (op == "s")
                        {
                            continue;
                        }
                        else if (op == "n")
                        {
                            break;
                        }
                    }
                    else if ((n % 2) == 1)
                    {
                        Console.WriteLine("IMPAR!");

                        Console.Write("deseja digitar outro número? s/n: ");
                        op = Console.ReadLine();

                        if (op == "s")
                        {
                            continue;
                        }
                        else if (op == "n")
                        {
                            break;
                        }
                    }
                }
            }
        }
    }
}
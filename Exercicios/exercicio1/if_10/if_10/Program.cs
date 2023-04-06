namespace if_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nome1, nome2;
            int idade1, idade2;
            double altura1, altura2;

            // Recebe os dados do primeiro atleta
            Console.WriteLine("Dados do primeiro atleta:");
            Console.Write("Nome: ");
            nome1 = Console.ReadLine();
            Console.Write("Idade: ");
            idade1 = int.Parse(Console.ReadLine());
            Console.Write("Altura: ");
            altura1 = double.Parse(Console.ReadLine());

            // Recebe os dados do segundo atleta
            Console.WriteLine("Dados do segundo atleta:");
            Console.Write("Nome: ");
            nome2 = Console.ReadLine();
            Console.Write("Idade: ");
            idade2 = int.Parse(Console.ReadLine());
            Console.Write("Altura: ");
            altura2 = double.Parse(Console.ReadLine());

            // Verifica qual atleta é mais novo e mais alto
            if (idade1 < idade2)
            {
                Console.WriteLine("Atleta mais novo: " + nome1 + " idade: " + idade1 + " anos" + " altura: " + altura1);
            }
            else
            {
                Console.WriteLine("Atleta mais novo: " + nome2 + " idade: " + idade2 + " anos" + " altura: " + altura2);
            }

            if (altura1 > altura2)
            {
                Console.WriteLine("Atleta mais alto: " + nome1 + " altura: " + altura1 + " idade: " + idade1 + " anos");
            }
            else
            {
                Console.WriteLine("Atleta mais alto: " + nome2 + " altura: " + altura2 + "idade: " + idade2 + " anos");
            }
        }
    }
}
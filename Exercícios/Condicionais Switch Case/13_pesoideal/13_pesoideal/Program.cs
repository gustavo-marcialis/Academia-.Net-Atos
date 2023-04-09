namespace _13_pesoideal
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string sexo;
            double altura, pesoideal;

            Console.Write("Digite seu Sexo (M ou F): ");
            sexo = Console.ReadLine();
            Console.Write("Digite sua Altura: ");
            altura = double.Parse(Console.ReadLine());

            switch (sexo)
            {
                case "M":
                    pesoideal = (72.7 * altura) - 50;
                    Console.WriteLine("Seu peso ideal é: " + pesoideal.ToString("F2"));
                break;
                case "F":
                    pesoideal = (62.1 * altura) - 44.7;
                    Console.WriteLine("Seu peso ideal é: " + pesoideal.ToString("F2"));
                    break;
                default:
                    Console.WriteLine("Sexo Inválido!");
                    break;
            }

        }
    }
}
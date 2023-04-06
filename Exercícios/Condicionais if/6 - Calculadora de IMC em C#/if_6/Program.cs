namespace if_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string cliente;
            double peso;
            double altura;
            double imc;

            Console.Write("Digite seu nome: ");
            cliente = Console.ReadLine();
            cliente = cliente.ToUpper();

            Console.Write("Digite seu Peso (em Kg) ");
            peso = double.Parse(Console.ReadLine());
            Console.Write("Digite sua Altura (em m) ");
            altura = double.Parse(Console.ReadLine());
            imc = peso / (altura * altura);
            Console.WriteLine(cliente);
            Console.WriteLine("IMC: " + imc);

            if (imc < 18.5)
            {
                Console.WriteLine("Você está abaixo do peso.");
            }
            else if (imc < 25)
            {
                Console.WriteLine("Seu peso está normal.");
            }
            else if (imc < 30)
            {
                Console.WriteLine("Você está com sobrepeso.");
            }
            else
            {
                Console.WriteLine("Você está obeso.");
            }
        }
    }
}
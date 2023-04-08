namespace _11_calcularvotos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int votostotais, votosvalidos, votosbrancos, votosnulos;
            double validosporcento, brancosporcento, nulosporcento;

            

            Console.Write("digite o total de votos: ");
            votostotais = int.Parse(Console.ReadLine());
            Console.Write("Votos Brancos: ");
            votosbrancos = int.Parse(Console.ReadLine());
            Console.Write("Votos Nulos: ");
            votosnulos = int.Parse(Console.ReadLine());
            votosvalidos = votostotais - votosbrancos - votosnulos;

            validosporcento = (votostotais * votosvalidos) / 100;
            brancosporcento = (votostotais * votosbrancos) / 100;
            nulosporcento = (votostotais * votosnulos) / 100;

            Console.WriteLine("Votos Válidos: " + validosporcento + "%");
            Console.WriteLine("Votos Brancos: " + brancosporcento + "%");
            Console.WriteLine("Votos Nulos: " + nulosporcento + "%");


        }
    }
}
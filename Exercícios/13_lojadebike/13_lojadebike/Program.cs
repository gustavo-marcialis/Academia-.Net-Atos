namespace _13_lojadebike
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double salarioMinimo, custo, vendas, valorVenda, salarioVendedor, comissao, totalVendas, salarioTotal;

            Console.Write("Digite o valor do salário mínimo: ");
            salarioMinimo = double.Parse(Console.ReadLine());

            Console.Write("Digite o custo de cada bicicleta: ");
            custo = double.Parse(Console.ReadLine());

            Console.Write("Digite o número de bicicletas vendidas pelo vendedor: ");
            vendas = double.Parse(Console.ReadLine());

            valorVenda = custo * 1.5; // valor de venda com acréscimo de 50%
            salarioVendedor = 2 * salarioMinimo; // salário do vendedor: 2 salários mínimos
            comissao = custo * 0.15 * vendas; // comissão do vendedor: 15% sobre o custo de cada bicicleta vendida
            totalVendas = valorVenda * vendas; // total de vendas: valor de venda x número de bicicletas vendidas
            salarioTotal = salarioVendedor + comissao + totalVendas; // salário total: salário do vendedor + comissão + total de vendas

            Console.WriteLine("Salário do vendedor: R$ " + salarioTotal.ToString("F2"));

        }
    }
}
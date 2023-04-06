using System.Diagnostics;

namespace if_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int codigo;
            string nome;
            double salariobase;
            double vendas;
            double salariototal;

            Console.Write("Digite seu codigo: ");
            codigo = int.Parse(Console.ReadLine());
            Console.Write("Digite seu nome: ");
            nome = Console.ReadLine();
            Console.Write("Digite seu salario: ");
            salariobase = double.Parse(Console.ReadLine());
            Console.Write("Digite o valor total das vendas: ");
            vendas = double.Parse(Console.ReadLine());

            Console.WriteLine("Codigo: "+codigo);
            Console.WriteLine("nome: "+nome);
            Console.WriteLine("salario: "+salariobase);
            Console.WriteLine("vendas: "+vendas);

            if (vendas > 500)
            {
                salariototal = salariobase + vendas + (vendas * 5 / 100);
                Console.WriteLine("Salario total: "+salariototal);
            }
            else if (vendas > 1000)
            {
                salariototal = salariobase + vendas + (vendas * 7 / 100);
                Console.WriteLine("Salario total: " + salariototal);
            }
            else if (vendas > 5000)
            {
                salariototal = salariobase + vendas + (vendas * 10 / 100);
                Console.WriteLine("Salario total: " + salariototal);
            }

        }
    }
}
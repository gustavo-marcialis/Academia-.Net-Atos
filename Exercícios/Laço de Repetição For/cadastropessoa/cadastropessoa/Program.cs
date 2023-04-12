using System;

namespace cadastropessoa
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nome;
            int idade;
            double salario;

            for (int i = 0; true; i++)
            {
                Console.Write("digite seu nome: ");
                nome = Console.ReadLine();

                if (!string.IsNullOrEmpty(nome) && nome.All(char.IsLetter))
                {
                    Console.WriteLine(nome);
                }
                else
                {
                    break;
                }

                Console.Write("digite sua idade: ");
                if (!int.TryParse(Console.ReadLine(), out idade) || idade <= 0)
                {
                    break;
                }

                Console.WriteLine(idade + " anos");

                Console.Write("digite seu salário: ");
                if (!double.TryParse(Console.ReadLine(), out salario) || salario <= 0)
                {
                    break;
                }

                Console.WriteLine("Salário: " + salario+"\r\n");

                Console.WriteLine("DADOS CADASTRADOS");
                Console.WriteLine("Nome: " + nome);
                Console.WriteLine("Idade: " + idade);
                Console.WriteLine("Salário: " + salario);

                break;
            }
        }
    }
}
namespace _11_horasvalidas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int hora, minuto;

            Console.Write("Digite a Hora: ");
            hora = int.Parse(Console.ReadLine());
            Console.Write("Digite o Minuto: ");
            minuto = int.Parse(Console.ReadLine());

            if (hora >= 0 && hora < 24) 
            {
                if (minuto >= 0 && minuto < 60)
                {
                    Console.Write(hora + ":" + minuto);
                }
                else
                {
                    Console.WriteLine("Hora Inválida");
                }
            }
            else
            {
                Console.WriteLine("Hora Inválida");
            }


        }
    }
}
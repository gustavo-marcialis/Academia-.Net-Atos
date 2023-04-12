namespace numerodefilhos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i, filhos, op1, op2, op3, op4;
            filhos = 0;
            op1 = 0;
            op2 = 0;
            op3 = 0;
            op4 = 0;

            for (i = 0; i < 30; i++)
            {
                Console.Write("Digite o número de filhos: ");
                filhos = int.Parse(Console.ReadLine());

                if (filhos == 0)
                {
                    op1 = op1 + 1;
                }
                else if (filhos >= 1 && filhos <= 3)
                {
                    op2 = op2 + 1;
                }
                else if (filhos >= 4 && filhos <= 7)
                {
                    op3 = op3 + 1;
                }
                else if (filhos >= 8)
                {
                    op4 = op4 + 1;
                }
            }

            

            Console.WriteLine("Nenhum filho: " + op1);
            Console.WriteLine("De 1 a 3 filhos: " + op2);
            Console.WriteLine("De 4 a 7 filhos: " + op3);
            Console.WriteLine("Mais de 8 filhos: " + op4);
        }
    }
}
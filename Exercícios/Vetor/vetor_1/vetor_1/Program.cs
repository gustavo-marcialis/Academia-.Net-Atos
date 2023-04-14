namespace vetor_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] n = new int[10];
            int par = 0, impar = 0;


            for (int i = 0; i < n.Length; i++)
            {
                Console.Write("Informe um valor para a posição " + i + ": ");
                n[i] = int.Parse(Console.ReadLine());

                if (n[i] % 2 == 0)
                {
                    par = par +1;
                }
                else
                {
                    impar = impar + 1;
                }

            }

            Console.WriteLine("Pares: " + par);
            Console.WriteLine("Ímpares: " + impar);



            
        }
    }
}
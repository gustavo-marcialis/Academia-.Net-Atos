namespace vetor_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] vetor1 = new int[20];
            int[] vetor2 = new int[20];
            int[] soma = new int[20];
            int i = 0, j = 0, k = 0;


            for (i = 0; i < vetor1.Length; i++)
            {
                Console.Write("Informe um valor para a posição " + i + " do vetor 1: ");
                vetor1[i] = int.Parse(Console.ReadLine());

                
            }

            for (j = 0; j < vetor2.Length; j++)
            {
                Console.Write("Informe um valor para a posição " + j + " do vetor 2: ");
                vetor2[j] = int.Parse(Console.ReadLine());


            }

            for (k = 0; k < soma.Length; k++)
            {
                soma[k] = vetor1[k] + vetor2[k];

                Console.Write("\n" + vetor1[k] + " + " + vetor2[k] + " = " + soma[k]);
            }






        }
    }
}
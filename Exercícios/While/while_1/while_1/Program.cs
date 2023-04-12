namespace while_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int joao, zeca, branco, nulo, nJoao, nZeca;
            string voto;
            joao = 0;
            zeca = 0;
            nZeca = 33;
            nJoao = 44;
            branco = 0;
            nulo = 0;

            while (true)
            {
                Console.Write("Vote JOAO, ZECA, BRANCO, NULO: ");
                voto = Console.ReadLine();
                Console.WriteLine("Digite FIM para encerrar");

                if (voto == "FIM")
                {
                    break;
                }

                switch (voto)
                {
                    case "JOAO":
                        joao = joao + 1;
                        break;
                    case "ZECA":
                        zeca = zeca + 1;
                        break;
                    case "BRANCO":
                        branco = branco + 1;
                        break;
                    case "NULO":
                        nulo = nulo + 1;
                        break;
                }
            }
            Console.WriteLine("JOAO: " + joao);
            Console.WriteLine("ZECA: " + zeca);
            Console.WriteLine("BRANCOS: " + branco);
            Console.WriteLine("NULOS: " + nulo +"\r\n");

            if (joao > zeca)
            {
                Console.WriteLine("JOÃO VENCEU!");
            }
            else if (zeca > joao)
            {
                Console.WriteLine("ZECA VENCEU!");
            }

            else if (branco > zeca && branco > joao)
            {
                Console.WriteLine("VOTAÇÃO ANULADA! Votos brancos foram maiores do que joao e zeca");
            }

            else if (nulo > zeca && nulo > joao)
            {
                Console.WriteLine("VOTAÇÃO ANULADA! Votos nulos foram maiores do que joao e zeca");
            }

            else
            {
                Console.WriteLine("EMPATE!");
            }
        }
    }
}
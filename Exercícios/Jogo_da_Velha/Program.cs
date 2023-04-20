using System;

namespace Jogo_da_Velha
{
    class Program
    {
        static char[,] tabuleiro = new char[3, 3]; // matriz para representar o tabuleiro
        static int jogadas = 0; // contador de jogadas

        static void Main(string[] args)
        {
            Console.WriteLine("Bem-vindo ao jogo da velha!");
            InicializarTabuleiro();
            DesenharTabuleiro();

            while (!FimDeJogo())
            {
                int linha, coluna;
                char jogador = (jogadas % 2 == 0) ? 'X' : 'O'; // define o jogador atual

                do
                {
                    Console.Write("Jogador {0}, informe a linha (1-3): ", jogador);
                    linha = int.Parse(Console.ReadLine()) - 1; // ajusta para o índice da matriz
                    Console.Write("Jogador {0}, informe a coluna (1-3): ", jogador);
                    coluna = int.Parse(Console.ReadLine()) - 1; // ajusta para o índice da matriz
                }
                while (!JogadaValida(linha, coluna));

                tabuleiro[linha, coluna] = jogador;
                jogadas++;
                DesenharTabuleiro();
            }

            if (VerificarVencedor('X'))
            {
                Console.WriteLine("Jogador X venceu!");
            }
            else if (VerificarVencedor('O'))
            {
                Console.WriteLine("Jogador O venceu!");
            }
            else
            {
                Console.WriteLine("Empate!");
            }

            Console.WriteLine("Pressione qualquer tecla para reiniciar o jogo.");
            Console.ReadKey();
            jogadas = 0;
            InicializarTabuleiro();
            Main(args); // reinicia o jogo
        }

        static void InicializarTabuleiro()
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    tabuleiro[i, j] = ' ';
                }
            }
        }

        static void DesenharTabuleiro()
        {
            Console.Clear();
            Console.WriteLine("  1 2 3");
            Console.WriteLine(" -------");
            for (int i = 0; i < 3; i++)
            {
                Console.Write("{0}|", i + 1);
                for (int j = 0; j < 3; j++)
                {
                    Console.Write("{0}|", tabuleiro[i, j]);
                }
                Console.WriteLine();
                Console.WriteLine(" -------");
            }
        }

        static bool JogadaValida(int linha, int coluna)
        {
            if (linha < 0 || linha > 2 || coluna < 0 || coluna > 2)
            {
                Console.WriteLine("Jogada inválida. Informe valores entre 1 e 3.");
                return false;
            }
            if (tabuleiro[linha, coluna] != ' ')
            {
                Console.WriteLine("Jogada inválida. Posição já ocupada.");
                return false;
            }
            return true;
        }

        static bool VerificarVencedor(char jogador)
        {
            for (int i = 0; i < 3; i++)
            {
                if (tabuleiro[i, 0] == jogador && tabuleiro[i, 1] == jogador && tabuleiro[i, 2] == jogador)
                {
                    return true; // linha completa
                }
                if (tabuleiro[0, i] == jogador && tabuleiro[1, i] == jogador && tabuleiro[2, i] == jogador)
                {
                    return true; // coluna completa
                }
            }
            if (tabuleiro[0, 0] == jogador && tabuleiro[1, 1] == jogador && tabuleiro[2, 2] == jogador)
            {
                return true; // diagonal principal completa
            }
            if (tabuleiro[0, 2] == jogador && tabuleiro[1, 1] == jogador && tabuleiro[2, 0] == jogador)
            {
                return true; // diagonal secundária completa
            }
            return false;
        }

        static bool FimDeJogo()
        {
            return jogadas == 9 || VerificarVencedor('X') || VerificarVencedor('O');
        }
    }
}

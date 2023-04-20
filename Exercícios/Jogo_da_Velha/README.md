# jogo da Velha
  
![C#](https://img.shields.io/badge/C%23-239120?style=for-the-badge&logo=c-sharp&logoColor=white)
  
  
 > O projeto consiste na implementação de um jogo da velha utilizando a linguagem C# e o Console App como interface gráfica. O objetivo é criar um jogo simples usando matrizes e funções em C#, além de introduzir conceitos básicos de programação como loops, condicionais e funções. O jogo da velha é um jogo conhecido por ser simples e fácil de entender, tornando-se um ótimo exemplo para mostrar como criar um jogo do zero, desde a inicialização do tabuleiro até a verificação do vencedor. O código apresentado é uma implementação básica do jogo, podendo ser utilizado como ponto de partida para a criação de outros jogos mais complexos em C#. 
  
 
 ## 💻 Pré-requisitos 
  
 Antes de começar, verifique se você atendeu aos seguintes requisitos: 

 * Tenha a IDE Visual Studio instalada na máquina;
 * Tenha o O pacote .NET Framework, que é necessário para compilar e executar aplicativos em C#.
 * Conhecimentos básicos em programação em C# e em lógica de programação, como estruturas de controle, condicionais e funções. 
  

 ## 🚀 Instalando o Jogo da Velha 
  
 Para instalar o Jogo da Velha, siga estas etapas: 
  
  * Abra o Visual Studio e selecione a opção "Criar um novo projeto";
  * Na janela que será aberta, selecione "Console App" e dê um nome ao projeto. Depois, clique em "Criar";
  * Copie e cole o código do jogo da velha no arquivo "Program.cs" do projeto que você acabou de criar;
  * Certifique-se de que o código foi colado corretamente e salve o arquivo;
  * Compile o código do jogo da velha clicando em "Depurar" e, em seguida, em "Compilar Solução". (Ou aperte F5);
 
  
## Explicando o código

* A matriz `tabuleiro` representa o estado atual do jogo, onde cada célula pode ser vazia (`' '`) ou ocupada por um jogador (`'X'` ou `'O'`).
* A variável `jogadas` conta o número de jogadas realizadas, sendo que o jogo acaba quando chega a 9 (tabuleiro completo) ou quando algum jogador vence.
* A função `InicializarTabuleiro` preenche todas as células do tabuleiro com espaços em branco.
* A função `DesenharTabuleiro` desenha o tabuleiro no console, com as células numeradas de 1 a 3 em cada linha e coluna.
* A função `JogadaValida` verifica se a jogada informada pelo jogador é válida, ou seja, se a posição está dentro do tabuleiro e se não está ocupada por outro jogador.
* A função `VerificarVencedor` verifica se o jogador informado venceu o jogo, percorrendo todas as linhas, colunas e diagonais do tabuleiro.
* A função `FimDeJogo` verifica se o jogo acabou (ou seja, se o tabuleiro está completo ou se algum jogador venceu).

No `Main`, o jogo começa chamando `InicializarTabuleiro` e `DesenharTabuleiro`, e depois entra em um loop que solicita a jogada de cada jogador e verifica se ela é válida usando `JogadaValida`. Se for válida, a jogada é realizada, atualizando a matriz `tabuleiro`, incrementando `jogadas` e chamando `DesenharTabuleiro` novamente. O loop continua até que `FimDeJogo` retorne `true`, momento em que é verificado se algum jogador venceu usando `VerificarVencedor` e o resultado é apresentado no console. Por fim, o jogo é reiniciado aguardando a entrada de uma tecla pelo jogador.
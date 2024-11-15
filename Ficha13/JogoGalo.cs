namespace Ficha13;
using System;

public class JogoGalo
{
    int[,] tabuleiro; 
    string[] jogadores; 
    int nJogada; 
    int proximoJogador;
    bool vitoria = false;
    int sum;

    // 1 para o jogador1 e 2 para o jogador2. 
    public JogoGalo(string nome1, string nome2) 
    { 
        tabuleiro = new int[3, 3]; 
        jogadores = new string[2]; 
        jogadores[0] = nome1; 
        jogadores[1] = nome2; 
        nJogada = 1; 
        proximoJogador = 0; 
    }
    
    
    //Verifica se alguem ganhou e return true ou false caso contrário
    /// <summary>
    /// Verificar a vitória
    /// </summary>
    /// <returns>bool true = vitoria |  bool false = derrota</returns>
    public bool VerificaVitoria()
    {
        //jogador 0 = bola
        //jogador 1 = x
        if (nJogada < 5)
        {
            vitoria = false;
        }
        
        //check diagonals
        if (tabuleiro[0,0] > 0 && tabuleiro[0, 0] == tabuleiro[1,1] && tabuleiro[1,1] == tabuleiro[2,2])
        {
            vitoria = true;
        }

        if (tabuleiro[0,2] > 0 && tabuleiro[0, 2] == tabuleiro[1, 1] && tabuleiro[0, 2] == tabuleiro[2, 0])
        {
            vitoria = true;
        }
        
        //colunas
        for (int cont = 0; cont < 3; cont++)
        {
            //se linha tiver inteira com 1 = jogador 1 ganha
            //se a linha tiver inteira com 0 = jogador 2 ganha
            int col = cont;
            if (tabuleiro[0, col] > 0 &&
                tabuleiro[0, col] == tabuleiro[1,col] &&
                tabuleiro[0, col] == tabuleiro[2,col])
            {
                vitoria = true;
            }

            int lin  = cont;
            if (tabuleiro[lin, 0] > 0 &&
                tabuleiro[lin, 0] == tabuleiro[lin,1] &&
                tabuleiro[lin, 0] == tabuleiro[lin,2])
            {
                vitoria = true;
            }

        }
        
        return vitoria;

    }
    
    /// <summary>
    /// Realiza a Jogada 
    /// </summary>
    /// <param name="lin"> Linha onde jogou</param>
    /// <param name="col"> Coluna onde jogou</param>
    /// <returns> -1000 = erro | -2 = jogador 1 ganhou | -1 = jogador 2 ganhou | -3 empate |
    /// 0 se o prox for o jogador 1 | 1 se o prox for jogador 2</returns>
    public int RecebeJogada(int lin, int col)
    {
        int ret;
        
        //jogada invalida - se ja estiver algo la
        //ou se nao for um numero entre 0 e 2
        //-1000 invalido
        if (lin < 0 || lin > 2 ||
            col < 0 || col > 2 ||
            tabuleiro[lin, col] > 0)
        {
            ret = -1000;
        }

        tabuleiro[lin, col] = proximoJogador + 1;
        

        if (VerificaVitoria())
        {
            return proximoJogador - 2;
            //-2 primeiro jogador
            //-1 segundo jogador
        }
        
        if (nJogada == 9)
        {
            //empate
            return -3;
        }
        
        nJogada++;
        
        proximoJogador = 1 - proximoJogador;

        return proximoJogador;
    }
    
    public void MostraTabuleiro()
    {
        // Console.WriteLine(" " + tabuleiro[0, 0] + " "
        //     + " | " + tabuleiro[0, 1] + " "
        //     + " | " + tabuleiro[0, 2] + " ");
        // Console.WriteLine("---+---+---");
        // Console.WriteLine(" " + tabuleiro[1, 0] + " "
        //     + " | " + tabuleiro[1, 1] + " "
        //     + " | " + tabuleiro[1, 2] + " ");
        //
        // Console.WriteLine(" " + tabuleiro[2, 0] + " "
        //     + " | " + tabuleiro[2, 1] + " "
        //     + " | " + tabuleiro[2, 2] + " ");
        // Console.WriteLine();
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                Console.Write(" " + tabuleiro[i, j]);
                if (j < 2) Console.Write(" |");
            }
            Console.WriteLine();
            if (i < 2) Console.WriteLine("---+---+---");
        }
    }

    public int LeInteiro(string prompt)
    {
        while (true)
        {
            Console.WriteLine(prompt);
            try
            {
                return int.Parse(Console.ReadLine() ?? string.Empty);
            }
            catch (Exception e)
            {
                Console.WriteLine("ERRO: *** Introduza um número ***: " + e.Message);
            }
            
        }
    }
}
using System;
//Criar um jogo simplificado onde dois jogadores podem jogar dados;
//Regras:
//• O jogo deverá solicitar o nome dos dois jogadores;
//O jogo terá 3 rodadas;
//O jogador que tirar o maior número nos dados nessas 3 rodadas vence;
//• Em caso de empate (onde os dois tiram o mesmo número), nenhum
//jogador pontuará;
//• Os números permitidos vão de 0 a 6.
//A aplicação informará qual dos jogadores tirou o maior número.

namespace Exercicio05.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] nomes = new string[2];
            int contaVitoriasPlayer1=0, contaVitoriasPlayer2=0, random1, random2;
            for (int i = 0; i < nomes.Length; i++)
            {
                Console.Write("Informe o nome do {0}º jogador: ",(i+1).ToString());
                nomes[i] = Console.ReadLine();
            }
            for (int i = 0; i < 3; i++)
            {
                Random randNum = new Random();
                random1 = randNum.Next(0, 6);
                random2 = randNum.Next(0, 6);
                Console.WriteLine("{0}ª rodada: \n {1}: {2} \n {3}: {4}", (i+1).ToString(), nomes[0], random1.ToString(), nomes[1], random2.ToString());
                if (random1 > random2) {
                    contaVitoriasPlayer1++;
                    Console.WriteLine("O jogador {0} jogou {1} e venceu a {2} rodada!",nomes[0], random1.ToString(), (i+1).ToString());
                }
                else if (random1 < random2)
                {
                    contaVitoriasPlayer2++;
                    Console.WriteLine("O jogador {0} jogou {1} e venceu a {2} rodada!", nomes[1], random2.ToString(), (i+1).ToString());
                }
                else
                    Console.WriteLine("Ouve um empate entre os jogadores {0} e {1}", nomes[0], nomes[1]);
            }
            Console.WriteLine("Valores {0} e {1}", contaVitoriasPlayer1.ToString(), contaVitoriasPlayer2.ToString());
            if (contaVitoriasPlayer1 == contaVitoriasPlayer2)
            {
                Console.WriteLine("Ouve um empate entre os jogadores, tentem novamente");
            }
            else if (contaVitoriasPlayer1 > contaVitoriasPlayer2)
            {
                Console.WriteLine("Parabéns {0}, você ganhou o jogo", nomes[0]);
            }
            else if(contaVitoriasPlayer1 < contaVitoriasPlayer2)
            {
                Console.WriteLine("Parabéns {0}, você ganhou o jogo", nomes[1]);
            }
            Console.ReadKey();
        }
    }
}

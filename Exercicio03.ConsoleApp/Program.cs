using System;
//Escreva um programa que contenha uma variável: horaAtual;
//Essa variável deverá conter a hora do dia e três mensagens deverão ser impressas na tela de acordo com a hora: “Bom dia”, “Boa tarde” ou “Boa noite”.
namespace Exercicio03.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int horaAtual;

            while (true)
            {
                Console.Write("Digite s para sair ou enter para continuar: ");
                if(Console.ReadLine() == "s")break;
                
                Console.Write("Informe a hora no formato 24h: ");
                horaAtual = Convert.ToInt32(Console.ReadLine());

                if (horaAtual >= 6 && horaAtual <= 12)
                    Console.WriteLine("Bom dia");
                
                else if (horaAtual >12 && horaAtual <= 18)
                    Console.WriteLine("Bom tarde");
                else if (horaAtual >18 && horaAtual <= 24 || horaAtual >= 0 && horaAtual < 6)
                    Console.WriteLine("Boa noite");
                else
                {
                    Console.WriteLine("Formato não identificado");
                    continue;
                }
            }

        }
    }
}

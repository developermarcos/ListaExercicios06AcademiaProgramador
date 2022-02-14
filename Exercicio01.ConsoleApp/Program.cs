using System;
//-Desenhe um retângulo com asteriscos, considere que o primeiro input é a largura do retângulo, e o segundo input é a altura.
namespace Exercicio01.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int larguraRetangulo = 50, alturaRetangulo = 10;
            string imprimirTela = "";
            for (int i = 0; i < alturaRetangulo; i++)
            {
                for (int z = 0; z < larguraRetangulo; z++)
                {
                    imprimirTela +="*";
                }
                imprimirTela +="\n";
            }
            Console.WriteLine(imprimirTela);
            Console.ReadKey();
        }
    }
}

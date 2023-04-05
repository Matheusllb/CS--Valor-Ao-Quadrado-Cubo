using System;

namespace CsE24
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //EXERCÍCIO 7
            Console.Write("Encontrando o quadrado e o cubo do valor\n\nInforme um valor: ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("            ² ³");
            for (int i = 1; i <= n; i++)
            {
                int primeiro = i;
                int segundo = i * i;
                int terceiro = i * i * i;
                Console.WriteLine($"Linha ({primeiro}): {segundo} {terceiro}");
            }
            Console.WriteLine("\nFim do Programa!\n");
        }
    }
}
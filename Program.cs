using System;

namespace cs_1._12_AvisoFesta5
{
    class Program
    {
        static void Main(string[] args)
        {
            int vezes;
            string Frase;

            Console.Clear();

            Console.Write("Digite a frase: ");
            Frase = Console.ReadLine();

            vezes = 0;

            do
            {
                Console.Write("Digite o número de repetições: ");
                vezes = int.Parse(Console.ReadLine());
            } while (vezes < 1);

            Console.WriteLine();

            for (int i = 0; i < vezes; i++)
            {
                Console.WriteLine(Frase);
            }
        }
    }
}

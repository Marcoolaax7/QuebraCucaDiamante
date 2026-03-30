using System;

namespace QuebraCuca
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.WriteLine("Digite um numero inteiro Ímpar: ");
            int numeroDigitado = Convert.ToInt32(Console.ReadLine());

            if (numeroDigitado % 2 != 0)
            {
                int metade = (numeroDigitado - 1) / 2;
                int espaco = metade;
                int xs = 1;


                for (int i = 0; i <= metade; i++)
                {
                    for (int i2 = 0; i2 < espaco; i2++)
                        Console.Write(" ");

                    for (int i2 = 0; i2 < xs; i2++)
                        Console.Write("X");

                    Console.WriteLine();

                    xs += 2;
                    espaco--;
                }

                xs -= 4;
                espaco += 2;

                for (int i = 0; i < metade; i++)
                {
                    for (int i2 = 0; i2 < espaco; i2++)
                        Console.Write(" ");

                    for (int i2 = 0; i2 < xs; i2++)
                        Console.Write("X");

                    Console.WriteLine();

                    xs -= 2;
                    espaco++;
                }
            }

            else
            {
                Console.WriteLine("Numero Invalido! Digite um numero Ímpar.");
                Console.ReadLine();
            }
        }
        
    }
}
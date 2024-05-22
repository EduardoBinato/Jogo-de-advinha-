using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jogo_de_advinha
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string secretWord = "amarelo";
            string guess = "";
            int guessCount = 0;
            int guessLimit = 3;
            bool outOfGuesses = false;

            while (guess != secretWord && !outOfGuesses)
            {
                if (guessCount < guessLimit)
                {
                    Console.Write("Faça uma tentativa: ");
                    guess = Console.ReadLine();
                    guessCount++;
                }
                else 
                {
                    outOfGuesses = true;
                }

                
            }
            if (outOfGuesses)
            {
                Console.Write("Voce Perdeu !");
            }
            else
            {
                Console.Write("Voce Venceu !");
            }
            

            Console.ReadLine();
        }
    }
}

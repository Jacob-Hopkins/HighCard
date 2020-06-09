using System;
using System.Collections.Generic;
using System.Threading;

/*
    Main()
    beginGame(): Checks user input to either launch the game or exit program
    startMessage(): Display message may have multiple calls depending on user input
    displayDelay(): Uses Thread.Sleep for "Loading" message effect
 */

namespace HighCardApplication
{
    class MainProgram
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to High Cards!");
            Console.WriteLine("----------------------");

            startMessage();
            beginGame();
        }

        static public void beginGame() 
        {
            try
            {
                int select = Convert.ToInt32(Console.ReadLine());
                if (select == 1)
                {
                    Game newGame = new Game();
                }
                else if (select == 2)
                {
                    Console.Write("\nClosing Program");
                    displayDelay(300);
                    return;
                }
                else
                {
                    Console.WriteLine("Invalid Input, Must be 1 or 2");
                    startMessage();
                    beginGame();
                }
            }
            catch(FormatException) //If input is not an integer, allows redo input
            {
                Console.WriteLine("Invalid Input, Must be 1 or 2");
                startMessage();
                beginGame();
            }
        }

        static public void startMessage()
        {
            Console.WriteLine("\n1) Start Game\n2) Exit Game");
            Console.Write("Select Option: ");
        }

        static public void displayDelay(int ms)
        {
            for (int i = 0; i < 3; i++)
            {
                Console.Write(".");
                Thread.Sleep(ms);//Half second delay
            }
        }

    }
}

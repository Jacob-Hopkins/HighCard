using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace HighCardApplication
{
    class Game
    {
        //Main Game constructor 
        public Game()
        {
            Player player1 = new Player(); // Creates player 1
            Player player2 = new Player(); // Creates player 2
            Deck deck = new Deck(); // New deck of cards
            
            bool keepPlaying = false; //Flag: If user continues to play

            do
            {
                deck.Shuffle(deck.Cards); //Shuffle deck of cards
                Console.Write("\nSuffling the deck");
                displayDelay(1000);

                Console.Write("\nNow dealing card to Player 1"); 
                displayDelay(300);
                dealCard(player1, deck); //Deal top card to player 1

                Console.Write("\nNow dealing card to Player 2"); 
                displayDelay(300);
                dealCard(player2, deck); //Deal next top card to player 2

                Console.WriteLine("\n\nPlayer 1: " + player1.card);
                Console.WriteLine("Player 2: " + player2.card);

                showHigh(player1.card, player2.card); //Determine and show high card
                Console.WriteLine("---------------------------");

                deck.Cards.Add(player1.card); //Adds player 1 card back to the deck
                deck.Cards.Add(player2.card); //Adds player 2 card back to the deck

                restartMessage();
                keepPlaying = checkChoice(Convert.ToInt32(Console.ReadLine())); //Keep playing?

            } while(keepPlaying); //Exits game if user does not want to keep playing
            
            Console.Write("\nClosing Program"); //End of program
            displayDelay(300);
        }

        //Compares rank to determine high card
        //If ranks are equal, checks suit values
        static void showHigh(Card a, Card b)
        {
            if ((a.rank) > (b.rank))
            {
                Console.WriteLine("\n{" + a + "} > {" + b + "}");
                Console.WriteLine("Player 1 Wins!");
            }        
            else if ((a.rank) < (b.rank))
            {
                Console.WriteLine("\n{" + a + "} < {" + b + "}");
                Console.WriteLine("Player 2 Wins!");
            }
            else
                checkSuits(a, b);  
        }

        //Compares suit values to determine high card
        static void checkSuits(Card a, Card b)
        {
            if (a.suit > b.suit)
            {
                Console.WriteLine("\n{" + a + "} > {" + b + "}");
                Console.WriteLine("Player 1 Wins!");
            }
            else
            {
                Console.WriteLine("\n{" + a + "} < {" + b + "}");
                Console.WriteLine("Player 2 Wins!");
            }
        }

        //Assigns top card to player
        //Temporarily removes card from deck (Card is in player's hand)
        void dealCard(Player player, Deck deck) 
        {
            player.card = deck.Cards[0];
            deck.Cards.RemoveAt(0);
        }

        //Checks user input, returns bool value accordingly
        //Catches input errors, returns checkChoice again until input is valid
        bool checkChoice(int c)
        {
            try
            {
                if (c == 1)
                    return true;
                else if (c == 2)
                    return false;
                else
                {
                    Console.WriteLine("\nNon-valid input, must be 1 or 2.");
                    restartMessage();
                    return checkChoice(Convert.ToInt32(Console.ReadLine()));
                }      
            }
            catch(FormatException)
            {
                Console.WriteLine("\nNon-valid input, must be 1 or 2.");
                restartMessage();
                return checkChoice(Convert.ToInt32(Console.ReadLine()));
            }
        }

        //Same user prompt may be called for differenct instances
        void restartMessage()
        {
            Console.WriteLine("\n1) Restart");
            Console.WriteLine("2) Quit Program");
            Console.Write("Enter Choice: ");
        }
        
        //Displays loading effect "..."
        void displayDelay(int ms)
        {
            for (int i = 0; i < 3; i++)
            {
                Console.Write(".");
                Thread.Sleep(ms);
            }
        }
    }
}

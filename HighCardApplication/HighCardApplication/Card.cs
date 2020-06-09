using System;
using System.Collections.Generic;
using System.Text;

/*
    Card(Suit suit, Rank rank): Sets attributes of "Card" to Suit and Rank parameters.

    ToString(): Overrides ToString method to return card format as {Value of Suit}
*/
namespace HighCardApplication
{
    class Card
    {
        public Rank rank;
        public Suit suit;

        public Card(Suit suit, Rank rank)
        {
            this.suit = suit;
            this.rank= rank;
        }

        public override string ToString()
        {
            return string.Format("{0} of {1}", rank, suit);
        }
    }
}

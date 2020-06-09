using System;
using System.Collections.Generic;
using System.Text;

/*
    Deck(): Loops through Enumeration for Suit and Ranks and adds all 52 cards
            to List<Card> cards.
    Shuffle(List<Card> deck): Method that shuffles a List<Cards> deck object.
                              Uses Fisher-Yates shuffle algorithm 
    public List<Card> Cards: Retrieves "List<Card> cards".
*/

namespace HighCardApplication
{
    class Deck
    {
        List<Card> cards = new List<Card>();

        public Deck()
        {
            foreach(Suit s in Enum.GetValues(typeof(Suit)))
            {
                foreach(Rank r in Enum.GetValues(typeof(Rank)))
                {
                    cards.Add(new Card(s, r));
                }
            }
        }

        public void Shuffle(List<Card> deck)
        {
            Random random = new Random();
            for (var i = deck.Count - 1; i > 0; i--)
            {
                var j = random.Next(i + 1);
                var temp = deck[i];
                deck[i] = deck[j];
                deck[j] = temp;
            }
        }

        public List<Card> Cards
        {
            get { return cards; }
        }
    }
}

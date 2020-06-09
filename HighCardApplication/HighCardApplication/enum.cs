using System;
using System.Collections.Generic;
using System.Text;

/*
    Enumeration class declares "Suit" and assigns values to each.
    Values represent ranking of suits (Clubs << Spades << Diamonds << Hearts).
    Rank here is arbitrary and can be set to fit different ranking conventions.
 */
namespace HighCardApplication
{
    enum Suit
    {
        Clubs = 1, Spades = 2, Diamonds = 3, Hearts = 4
    }
    enum Rank
    {
        Two = 2,
        Three = 3,
        Four = 4,
        Five = 5,
        Six = 6,
        Seven = 7,
        Eight = 8,
        Nine = 9,
        Ten = 10,
        Jack = 11,
        Queen = 12,
        King = 13,
        Ace = 14
    }
}

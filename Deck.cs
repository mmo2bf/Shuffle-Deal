/* Deck class makes a new deck 
 * that contains 52 cards, each 
 * individual with a value (Ace, 
 * 2-10, Jack, Queen, King) and 
 * a suit (Hearts, Spades, Clubs, 
 * Diamonds).
 * */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETSInterview_ohara
{
    class Deck
    {

        // Create new deck using List
        public static List<makeCard.Card> makeDeck()
        {
            List<makeCard.Card> deck = new List<makeCard.Card>();
            foreach (makeCard.Suit s in Enum.GetValues(typeof(makeCard.Suit)))
            {
                foreach (makeCard.Value v in Enum.GetValues(typeof(makeCard.Value)))
                {
                    deck.Add(new makeCard.Card(v, s));

                } // end Value foreach
            } // end Suit foreach
            return deck;
        } // end makeDeck() 

    }
}


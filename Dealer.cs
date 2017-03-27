/* Dealer class has two methods: 
 * shuffle(): shuffles the deck
 * dealOneCard(): deals one card 
 * and takes the card out of the 
 * deck.
 * */ 

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETSInterview_ohara
{
    class Dealer
    {
        // shuffle() returns no value, but results in the deck being randomly permuted 
        // pass by reference to shuffle list without having a return value
        // Using Fisher-Yates Shuffle 
        public static void shuffle(ref List<makeCard.Card> deck)
        {
            int n = deck.Count;
            for (int i = n - 1; i >= 0; i--)
            {
                Random j = getRandom.GetThreadRandom();
                int jInt = j.Next(0, n);
                makeCard.Card tempI = deck[i];
                makeCard.Card tempJ = deck[jInt];
                deck[i] = tempJ;
                deck[jInt] = tempI;
            } // end for loop
        } //end shuffle()

        // dealOneCard() returns one card from the deck to the caller.  Can only be called
        // 52 times per deck.
        public static dynamic dealOneCard(List<makeCard.Card> deck)
        {   
            // check size of deck; can only deal if count > 0
            if (deck.Count > 0)
            {
                makeCard.Card retVal = deck[0];
                deck.RemoveAt(0);
                return retVal;
            } // end if
           else
            {
                return "All cards in this deck have been dealt";
            } // end else
        } // end dealOneCard() 
    }
}

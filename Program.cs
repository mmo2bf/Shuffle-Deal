/* Contains the Main() method.
 * Main() method will demonstrate
 * the uses of the makeCard, Deck, and
 * Dealer classes by making a deck, 
 * shuffing it, and dealing all 
 * cards to the caller .
 * 
 * */ 

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETSInterview_ohara
{
    class Program
    {
        static void Main(string[] args)
        {

            // make a new deck
            List<makeCard.Card> deck = Deck.makeDeck();

            // shuffle the deck
            Dealer.shuffle(ref deck); 

            // return all cards in deck
            for (int i = 1; i <= 52; i ++)
            {
                //Console.Write(Dealer.dealOneCard(deck)); 
                Console.WriteLine(Dealer.dealOneCard(deck));
            }

            // Show that you cannot deal more than 52 cards
            Console.WriteLine(Dealer.dealOneCard(deck)); 


            Console.ReadKey();


        }
    }
}

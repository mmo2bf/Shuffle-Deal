/*
 * makeCard class sets up an individual 
 * card to be used in the deck. 
 * Has two properties: suit & value. 
 * Suit is Hearts, Spades, Clubs, 
 * Diamonds.  Value is Ace, 2-10, Jack, 
 * Queen, King.
 * */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETSInterview_ohara
{
    class makeCard
    {
        public struct Card
        {
            // two fields 
            public Value Value { get; set; }
            public Suit Suit { get; set; }

            // constructor 
            public Card(Value v, Suit s)
            {
                this.Value = v;
                this.Suit = s;
            }


            // for dealing a Card to the caller
            public override string ToString()
            {
                return Value + " of " + Suit;
            }
        }

        // enums for Value and Suit
        public enum Value { Ace, Two, Three, Four, Five, Six, Seven, Eight, Nine, Ten, Jack, Queen, King };
        public enum Suit { Hearts, Spades, Clubs, Diamonds };

    }
}

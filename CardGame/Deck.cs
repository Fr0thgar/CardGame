using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardGame
{
    class Deck
    {
        Card[] cards = new Card[76];

        public Deck()
        {
            for (int i = 0; i < 10; i++)
            {
                cards[i] = new Card("red", i);
                    cards[i+9] = new Card("red", i);

                cards[i+19] = new Card("blue",i);
                    cards[i + 28] = new Card("blue", i);

                cards[i+38] = new Card("yellow", i);
                    cards[i + 47] = new Card("yellow", i);

                cards[i+57] = new Card("green", i);
                    cards[i + 66] = new Card("green", i);
            }

            for (int i = 0; i < cards.Length; i++)
            {
                Console.WriteLine(cards[i]);
            }
        }

    }
}

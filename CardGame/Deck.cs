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
                //Red Cards
                cards[i] = new Card("red", i);
                cards[i + 9] = new Card("red", i);

                //Blue Cards
                cards[i + 19] = new Card("blue", i);
                cards[i + 28] = new Card("blue", i);

                //Yellow Cards
                cards[i + 38] = new Card("yellow", i);
                cards[i + 47] = new Card("yellow", i);

                //Green Cards
                cards[i + 57] = new Card("green", i);
                cards[i + 66] = new Card("green", i);
            }

            shuffel();

        }

        private void shuffel()
        {
            Random random = new Random();
            Card[] randomCards = cards.OrderBy(x => random.Next()).ToArray();
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < cards.Length; i++)
            {
                sb.Append(cards[i]);
                sb.Append("; ");
            }

            return sb.ToString();
        }
    }
}

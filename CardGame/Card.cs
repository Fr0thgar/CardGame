using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardGame
{
    class Card
    {
        public String Colour { get; set; }
        public int Value { get; set; }

        public Card(string colour, int value)
        {
            Colour = colour;
            Value = value;
        }

        public override string ToString()
        {
            return $"[{Value}, {Colour}]";
        }
    }
}

using System;

namespace Deck_of_Cards
{
    public class Card
    {
        public string Face;
        public string Suit;
        public int Value;

        public Card(string face, string suit)
        {
            Face = face;
            Suit = suit;
        }
        public void Show()
        {
            Console.WriteLine($"Player has a {Face} of {Suit}");
        } 
    }
}
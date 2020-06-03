using System;
using System.Collections.Generic;

namespace Deck_of_Cards
{
    public class Player
    {
        public string Name;
        public List<Card> hand = new List<Card>();

        public Player(string name)
        {
            Name = name;
        }

        public void Draw(Deck deck)
        {
            hand.Add(deck.Deal());
        }

        public Card Discard(int index)
        {
            if(hand.Count > index)
            {
                Card discarded = hand[index];
                hand.Remove(discarded);
                return discarded;
            }
            return null;
        }
    }
}
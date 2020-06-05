using System;
using System.Collections.Generic;

namespace Deck_of_Cards
{
    public class Deck
    {
        public List<Card> cards;
        private static Random rand = new Random();

        public Deck()
        {
            cards = new List<Card>();
            string[] suits = {"Diamonds", "Hearts", "Clubs", "Spades"};
            string[] faces = {"Ace", "2", "3", "4", "5", "6", "7", "8", "9", "10", "King", "Queen", "Jack"};
            foreach(string face in faces)
            {
                foreach(string suit in suits)
                {
                    cards.Add(new Card(face, suit));
                }
            }
        }

        public Card Deal()
        {
            Card cardToReturn = cards[0];
            cards.RemoveAt(0);
            return cardToReturn;
        }

        public void Shuffle()
        {
            for(var i=0; i<cards.Count; i++)
            {
                int randIndex = rand.Next(cards.Count);
                Card temp = cards[0];
                cards[0] = cards[randIndex];
                cards[randIndex] = temp;
            }
        }

        public void Reset()
        {
            Reset();
        }
    }
}
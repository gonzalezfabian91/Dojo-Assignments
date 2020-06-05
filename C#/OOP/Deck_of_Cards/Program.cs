using System;

namespace Deck_of_Cards
{
    class Program
    {
        static void Main(string[] args)
        {
            Deck MyDeck = new Deck();
            MyDeck.Shuffle();
            Player me = new Player("Fabian");
            Console.WriteLine(MyDeck.cards.Count);
            me.Draw(MyDeck);
            me.Draw(MyDeck);
            me.Draw(MyDeck);
            me.Draw(MyDeck);
            me.Draw(MyDeck);
            foreach(Card c in me.hand)
            {
                c.Show();
            }
            me.Discard(0);
            me.Discard(3);
            Console.WriteLine(MyDeck.cards.Count);
            foreach(Card c in me.hand)
            {
                c.Show();
            }
        }
    }
}

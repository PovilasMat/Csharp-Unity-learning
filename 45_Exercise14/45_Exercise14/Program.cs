using ConsoleCards;

namespace _45_Exercise14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Deck deck = new Deck();
            List<Card> hand = new List<Card>();
            deck.Shuffle();

            for (int i = 0; i < 5; i++)
            {
                hand.Add(deck.TakeTopCard());
            }

            foreach (Card card in hand)
            {
                card.FlipOver();
            }

            foreach (Card card in hand)
            {
                card.Print();
            }
        }
    }
}

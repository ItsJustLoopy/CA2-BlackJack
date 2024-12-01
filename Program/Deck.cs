namespace Program;

public class Deck
{
    public List<Card> Cards { get; set; } = new List<Card>(); // List of cards in the deck
    private string[] Ranks = ("A 2 3 4 5 6 7 8 9 10 J Q K").Split(' '); // Array of ranks
    private string[] Suits = ("Hearts Diamonds Clubs Spades").Split(' '); // Array of suits

    public Deck() // Constructor to create a deck with all 52 cards
    {
        foreach (var suit in Suits)
        {
            foreach (var rank in Ranks)
            {
                Cards.Add(new Card(suit, rank));
            }
        }
    }

    public void Shuffle()
    {
        Random random = new Random(); // Shuffles the deck by swapping each card with another random card
        for (int i = 0; i < Cards.Count; i++)
        {
            int j = random.Next(Cards.Count);
            Card temp = Cards[i];
            Cards[i] = Cards[j];
            Cards[j] = temp;
        }
    }

    public Card Draw() // Draws a card from the deck by removing the first card from a shuffled deck
    {
        Card card = Cards[0];
        Cards.RemoveAt(0);
        return card;
    }
}
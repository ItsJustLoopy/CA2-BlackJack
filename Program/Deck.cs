namespace Program;

public class Deck
{
    public List<Card> Cards { get; set; } = new List<Card>();
    private string[] Ranks = ("A 2 3 4 5 6 7 8 9 10 J Q K").Split(' ');
    private string[] Suits = ("Hearts Diamonds Clubs Spades").Split(' ');

    public Deck()
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
        Random random = new Random();
        for (int i = 0; i < Cards.Count; i++)
        {
            int j = random.Next(Cards.Count);
            Card temp = Cards[i];
            Cards[i] = Cards[j];
            Cards[j] = temp;
        }
    }

    public Card Draw()
    {
        Card card = Cards[0];
        Cards.RemoveAt(0);
        return card;
    }
}
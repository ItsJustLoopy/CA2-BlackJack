namespace Program;

public class Card
{
    public string Suit { get;}
    public string Rank { get;}
    
    public Card(string suit, string rank)
    {
        Suit = suit;
        Rank = rank;
    }
    
    public int GetValue()
    {
        if (Rank == "A")
        {
            return 0;
        }
        else if (Rank == "K" || Rank == "Q" || Rank == "J")
        {
            return 10;
        }
        else
        {
            return int.Parse(Rank);
        }

    }
    
    public override string ToString()
    {
        return $"{Rank} of {Suit}";
    }
}
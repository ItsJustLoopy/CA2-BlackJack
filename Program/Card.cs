namespace Program;

public class Card
{
    public string Suit { get;}
    public string Rank { get;}
    
    public Card(string suit, string rank) // Constructor to create a card object
    {
        Suit = suit;
        Rank = rank;
    }
    
    public int GetValue() // Method to get the value of a card
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
    
    public override string ToString() // Method to return the card name as a string
    {
        return $"{Rank} of {Suit}";
    }
}
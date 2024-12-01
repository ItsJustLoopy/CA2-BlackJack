namespace Program;

public class Player
{
    public Player() // Constructor to create a player object
    {
        Hand = new List<Card>();
        Score = 0;
        IsBusted = false;
    }
    public List<Card> Hand { get; set; } // List of cards in the player's hand
    public int Score { get; set; } // Total value of the player's hand
    
    public bool IsBusted;
    
    public void DrawCard(ref Deck deck) // Draws a card from the deck and adds it to the player's hand
    {
        Card card = deck.Draw();
        Hand.Add(card);
        
       if (card.Rank == "A")
        {
            DecideAceValue();
        }
        
        Score += card.GetValue();
        if (Score > 21)
        {
            IsBusted = true;
        }
    }
    
    public void ShowHand() // Displays the player's hand and its total value and draws the cards
    {
        Program.CenterText("\n");
        Program.CenterText($"Player's Hand: {string.Join(", ", Hand)} (Value: {Score})\n");

        foreach (var card in Hand)
        {
            ASCII.DrawCard(card);
        }

    }

    public virtual void DecideAceValue() // Method to allow the player to decide the value of an Ace card, it is virtual to allow the Dealer class to override it
    {
        Program.CenterText("\n");
        Program.CenterText("You have drawn an Ace! Do you want the Ace to be worth 1 or 11? (1/11): ");
        string response = Console.ReadLine();
        
        if (response == "1")
        {
            Score += 1;
        }
        else if (response == "11")
        {
            Score += 11;
        }
        else
        {
            Program.CenterText("Invalid input, please enter 1 or 11");
            DecideAceValue();
        }
    }
    

}
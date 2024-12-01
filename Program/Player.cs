namespace Program;

public class Player
{
    public Player()
    {
        Hand = new List<Card>();
        Score = 0;
        IsBusted = false;
    }
    public List<Card> Hand { get; set; }
    public int Score { get; set; }
    public bool IsBusted;
    
    public void DrawCard(ref Deck deck)
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
    
    public void ShowHand()
    {
        Program.CenterText("\n");
        Program.CenterText($"Player's Hand: {string.Join(", ", Hand)} (Value: {Score})\n");

    }

    public virtual void DecideAceValue()
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
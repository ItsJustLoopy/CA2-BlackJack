namespace Program;

public class Dealer : Player
{
    public Dealer ()
    {
        Hand = new List<Card>();
        Score = 0;
        IsBusted = false;
    }
    
    public void ShowHand(bool showFirstCard = false)
    {
        if (showFirstCard)
        {
            Program.CenterText($"Dealer's Hand: {Hand[0]} & a secret hole card");
            Program.CenterText("\n");
        }
        else
        {
            Program.CenterText($"Dealer's Hand: {string.Join(", ", Hand)} (Value: {Score})");
            Program.CenterText("\n");
        }
    }

    public void ShouldDrawCard(ref Deck deck)
    {
        if (Score < 17)
        {
            DrawCard(ref deck);
        }
    }
    
    public override void DecideAceValue()
    {
        if (Score + 11 <= 21)
        {
            Score += 11;
        }
        else
        {
            Score += 1;
        }
    }
}
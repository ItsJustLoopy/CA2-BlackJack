namespace Program;

public class Dealer : Player // Dealer class that inherits from the Player class
{
    public Dealer () // Constructor to create a dealer object
    {
        Hand = new List<Card>();
        Score = 0;
        IsBusted = false;
    }
    
    public void ShowHand(bool showFirstCard = false) // Displays the dealer's hand and its total value and draws the cards
    {
        if (showFirstCard) // On the first turn, the dealer's second card is hidden
        {
            Program.CenterText($"Dealer's Hand: {Hand[0]} & a secret hole card");
            Program.CenterText("\n");
            
            ASCII.DrawCard(Hand[0]);
        }
        else
        {
            Program.CenterText($"Dealer's Hand: {string.Join(", ", Hand)} (Value: {Score})");
            Program.CenterText("\n");
            
            foreach (var card in Hand)
            {
                ASCII.DrawCard(card);
            }
        }
    }

    public void ShouldDrawCard(ref Deck deck) // Method to decide if the dealer should draw another card, the dealer will always draw a card if their hand is less than 17
    {
        if (Score < 17)
        {
            DrawCard(ref deck);
        }
    }
    
    public override void DecideAceValue() // Method to decide the value of an Ace card, the dealer will always choose the value that doesn't bust their hand
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
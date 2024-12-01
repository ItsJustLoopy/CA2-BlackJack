namespace Program;

public class ASCII
{
    public static void DrawCard(Card card) // Method to draw a card in ASCII art depending on the card's rank's length [ADDITIONAL FEATURE]
    {
        string suit = GetSuitSymbol(card.Suit);

        string rank = card.Rank;
        if (rank.Length == 2)
        {
            string[] cardArt =
            {
                "┌─────────┐", 
                $"|{card.Rank}       |",
                "|         |",
                $"|    {suit}    |",
                "|         |", 
                $"|       {card.Rank}|",
                "└─────────┘"
            };
            foreach (string line in cardArt)
            {
                Program.CenterText(line);
                Console.Write("\n");
            }
        }
        else
        {

            string[] cardArt =
            {
                "┌─────────┐",
                $"|{card.Rank}        |",
                "|         |",
                $"|    {suit}    |",
                "|         |",
                $"|        {card.Rank}|",
                "└─────────┘"
            };
            foreach (string line in cardArt)
            {
                Program.CenterText(line);
                Console.Write("\n");
            }
        }


        
    }

    public static string GetSuitSymbol(string suit) // Method to get the unicode symbol for a suit
    {
        return suit switch
        {
            "Hearts" => "♥",
            "Diamonds" => "♦",
            "Clubs" => "♣",
            "Spades" => "♠"
        };
    }
}
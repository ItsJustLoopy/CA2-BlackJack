namespace Program;


class Program
{
    public static void Main(string[] args)
    {
        CenterText("Would you like to play BlackJack ? (y/n): ");
        string response = Console.ReadLine().ToLower();
        CenterText("\n");
        
        if (response == "y") // Start game if user enters "y"
        {
            Game game = new Game();
            game.Start();
        }
        else
        {
            CenterText("are you sure? (y/n): ");
            string response2 = Console.ReadLine().ToLower();
            CenterText("\n");
            
            if (response2 == "y")
            {
                CenterText("Are you 100% certain? (y/n): ");
                string response3 = Console.ReadLine().ToLower();
                CenterText("\n");
                
                if (response3 == "y")
                {
                    CenterText("You have made me very sad");
                    return;
                }
                else
                {
                    Game game = new Game();
                    game.Start();
                }

            }
            else
            {
                Game game = new Game();
                game.Start();
            }

        }
        
    }
    
    public static void NewGame() // Method to start a new game
    {
        Game game = new Game();
        game.Start();
    }
    
    public static void CenterText(string text) // Method to center text in the console
    {
        int screenWidth = Console.WindowWidth;
        int stringWidth = text.Length;
        int spaces = (screenWidth / 2) + (stringWidth / 2);
        Console.Write(text.PadLeft(spaces));
    }

}
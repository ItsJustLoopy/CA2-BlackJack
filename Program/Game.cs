namespace Program;

public class Game
{
    private Deck _deck;
    private Player _player;
    private Dealer _dealer;

    public bool gameOver = false;

    public Game()
    {
        _deck = new Deck();
        _player = new Player();
        _dealer = new Dealer();
    }
    
    public void Start()
    {
        Program.CenterText("\n");
        Program.CenterText("----------Blackjack----------");
        Program.CenterText("\n");
        
        _deck.Shuffle();
        
        for (int i = 0; i < 2; i++)
        {
            _player.DrawCard(ref _deck);
            _dealer.DrawCard(ref _deck);
        }
        
        _player.ShowHand();
        _dealer.ShowHand(true);
        PlayerTurn();
        

    }
    
    private void PlayerTurn()
    {

        while (!_player.IsBusted && !gameOver)
        {
            
            Program.CenterText("Do you want to draw another card? (y/n): ");
            string response = Console.ReadLine().ToLower();
            Program.CenterText("\n");
            
            if (response == "y")
            {
                _player.DrawCard(ref _deck);
                _player.ShowHand();
                PlayerTurn();
                
            }
            else if (response == "n")
            {
                break;
            }
            
            
        }

        DealerTurn();
    }
    
    private void DealerTurn()
    {
       
        
        if (!_dealer.IsBusted && !gameOver)
        {
            _dealer.ShouldDrawCard(ref _deck);
            _dealer.ShowHand();
            DetermineWinner();
        }
    }
    
    private void DetermineWinner()
    {
        if (_player.IsBusted)
        {
            Program.CenterText("\n");
            Program.CenterText("----------Dealer wins!----------");
        }
        else if (_dealer.IsBusted)
        {
            Program.CenterText("\n");
            Program.CenterText("----------Player wins!----------");
        }
        else if (_player.Score > _dealer.Score)
        {
            Program.CenterText("\n");
            Program.CenterText("----------Player wins!----------");
        }
        else if (_dealer.Score > _player.Score)
        {
            Program.CenterText("\n");
            Program.CenterText("----------Dealer wins!----------");
        }
        else
        {
            Program.CenterText("\n");
            Program.CenterText("----------It's a tie!----------");
        }
        
        End();
    }
    
    private void End()
    {
        Program.CenterText("\n");
        Program.CenterText("----------Thanks for playing!----------");
        
        
        Program.CenterText("\n");
        Program.CenterText("Would you like to play again? (y/n): ");
        if (Console.ReadLine().ToLower() == "y")
        {
            Program.NewGame();
        }
        else
        {
            gameOver = true;
        }
        
        
        
    }
}
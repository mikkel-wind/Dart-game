class Program
{
    Game game;
    Player player;
    public static void Main(string[] args)
    {
        Player player1 = new Player("");
        player1.SetupPlayer();

        Player player2 = new Player("");
        player2.SetupPlayer();

        Game game1 = new Game(0,0,0);
        game1.SetUpGame();

        
    }
}

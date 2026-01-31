class Player
{
    private string name;


    public Player (string name)
    {
        this.name = name;
    }

    public void SetupPlayer()
    {
        Console.Write("Enter player name: ");
        Name = Console.ReadLine() ?? "Player";
    }
  
}

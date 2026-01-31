class Player
{
    private string name;


    public Player (string name)
    {
        this.name = name;
    }

    public string SetupPlayer()
    {
        Console.Clear();
        Console.Write("Enter player name: ");
        name = Console.ReadLine() ?? "Player";
        return name;
    }

  
}

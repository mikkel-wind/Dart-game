class Player
{
    private string name;
    private int targetScore;
    private int score;



    public Player (string name, int targetScore)
    {
        this.name = name;
        this.targetScore = targetScore;
    }

    public void GetName()
    {
        string name = Console.ReadLine("Enter your Name");
        return name;
    }

    public void GetTargetScore()
    {
        Console.ReadLine("Enter the wanted target score");
    }

    public void GetScore()
    {
        return score;
    }
}

class Program
{
    public static void Main(string[] args)
    {
        Player player1 = new Player();
        player1.GetName();
    }
}
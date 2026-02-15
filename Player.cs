class Player
{
    private string name;
    private int targetScore;
    private int initialTargetScore;
    private int targetSets;
    private int targetLegs;
    
    private int currentSets;
    private int currentLegs;
  


    public Player (string name, int targetScore, int targetSets, int targetLegs, int  currentSets, int currentLegs, int initialTargetScore)
    {
        this.name = name;
        this.initialTargetScore = targetScore;
        this.targetScore = targetScore;
        this.targetSets = targetSets;
        this.targetLegs = targetLegs;
        this.currentSets = currentSets;
        this.currentLegs = currentLegs;
    }

    public void SetupPlayer()
    {
        Console.Clear();
        Console.Write("Enter player name: ");
        name = Console.ReadLine() ?? "Player";
        
        Console.Write("Enter the score you would like to play to ");
        if (int.TryParse(Console.ReadLine(),out int valueForTargetScore))
        {
            targetScore = valueForTargetScore;
            initialTargetScore = valueForTargetScore;
        } else
        {
            Console.WriteLine("Not a valid number, please type a number");
            valueForTargetScore = int.Parse(Console.ReadLine());
            initialTargetScore = valueForTargetScore;
        }
        targetScore = valueForTargetScore; 
        Console.Write("Enter the wanted number of Legs you would like to play: ");
        if (int.TryParse(Console.ReadLine(),out int valueForTargetLegs))
        {
            targetLegs = valueForTargetLegs;
        } else
        {
            Console.WriteLine("Not a valid number, please type a number");
            valueForTargetLegs = int.Parse(Console.ReadLine());
        }
        Console.WriteLine("You are playing to " + valueForTargetLegs + " legs");
        targetLegs = valueForTargetLegs;



        Console.Write("Enter the wanted number of sets you would like to play ");
         if (int.TryParse(Console.ReadLine(),out int valueForTargetSets))
        {
            targetSets = valueForTargetSets;
        } else
        {
            Console.WriteLine("Not a valid number, please type a number");
            valueForTargetSets = int.Parse(Console.ReadLine());
        }
        Console.WriteLine("You are playing to " + valueForTargetSets + " sets");
        targetSets = valueForTargetSets;
    }  

    public int GetTargetScore()
    {
        return targetScore;
    }


    public void NeededToWin()
    {
        int scored = int.Parse(Console.ReadLine());
        if (scored > 180)
        {
            Console.WriteLine("Cannot score more than 180");
        }
        else
        {
            targetScore -= scored;
        }

    }

    public int GetCurrentSets()
    {
        return currentSets;
    }

    public int GetCurrentLegs()
    {
        return currentLegs;
    }
    

    public string GetName()
    {
        return name;
    }
    public int GetTargetSets()
    {
        return targetSets;
    }

    public int GetTargetLegs()
    {
        return targetLegs;
    }

    public void IncrementLegs()
    {
        currentLegs++;
        targetScore = initialTargetScore;
        
    }

    public void IncrementSets()
    {
        currentSets++;
    }

}

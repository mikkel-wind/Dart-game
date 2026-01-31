class Game
{
    int targetScore;
    int targetSets;
    int targetLegs;

    public Game(int targetLegs, int targetScore, int targetSets)
    {
        this.targetLegs = targetLegs;
        this.targetScore = targetScore;
        this.targetSets = targetSets;
    }

    public void SetUpGame()
    {
        Console.Clear();
        Console.Write("Enter the wanted score you want to play to: ");
        if (int.TryParse(Console.ReadLine(),out int valueForTargetScore))
        {
            targetScore = valueForTargetScore;
        } else
        {
            Console.WriteLine("Not a valid number, please type a number");
            valueForTargetScore = int.Parse(Console.ReadLine());
            
        }
        Console.WriteLine("You are playing to " + valueForTargetScore);
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



}
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
        Console.Write("Enter the wanted score you want to play to: ");
        if (int.TryParse(Console.ReadLine(),out int valueForTargetScore))
        {
            Console.WriteLine("You entered " + valueForTargetScore);
        } else
        {
            Console.WriteLine("Not a valid Number");
        }
        targetScore = valueForTargetScore;

        Console.Write("Enter the wanted number of Legs you would like to play: ");
        if (int.TryParse(Console.ReadLine(),out int valueForTargetLegs))
        {
            Console.WriteLine("You entered " + valueForTargetLegs);
        } else
        {
            Console.WriteLine("Not a valid Number");
        }
        targetLegs = valueForTargetLegs;

        Console.Write("Enter the wantd number of sets you would like to play ");
         if (int.TryParse(Console.ReadLine(),out int valueForTargetSets))
        {
            Console.WriteLine("You entered " + valueForTargetSets);
        } else
        {
            Console.WriteLine("Not a valid Number");
        }

        targetSets = valueForTargetSets;
    }



}
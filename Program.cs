using System.Runtime.Intrinsics.Arm;

class Program
{
    public static void Main(string[] args)
    {
        Player player1 = new Player("", 0,0,0,0,0,0);
        player1.SetupPlayer();

        Player player2 = new Player("", 0,0,0,0,0,0);
        player2.SetupPlayer();

        // Play until one player reaches target legs
        while (player1.GetCurrentLegs() < player1.GetTargetLegs() && 
               player2.GetCurrentLegs() < player2.GetTargetLegs())
        {
            // Player 1's turn
            Console.WriteLine("\n--- " + player1.GetName() + "'s turn ---");
            Console.WriteLine(player1.GetName() + " needs " + player1.GetTargetScore());
            Console.Write("Enter score: ");
            player1.NeededToWin();
            
            // Check if player1 won the leg
            if (player1.GetTargetScore() == 0)
            {
                player1.IncrementLegs();
                Console.WriteLine(player1.GetName() + " wins the leg! Score: " + 
                                  player1.GetCurrentLegs() + "-" + player2.GetCurrentLegs());
                
                // Check if player1 won the match
                if (player1.GetCurrentLegs() >= player1.GetTargetLegs())
                {
                    Console.WriteLine("\n🎯 " + player1.GetName() + " WINS THE MATCH! 🎯");
                    break;
                }
                continue; // Skip player2's turn, start new leg
            }
            
            // Player 2's turn
            Console.WriteLine("\n--- " + player2.GetName() + "'s turn ---");
            Console.WriteLine(player2.GetName() + " needs " + player2.GetTargetScore());
            Console.Write("Enter score: ");
            player2.NeededToWin();
            
            // Check if player2 won the leg
            if (player2.GetTargetScore() == 0)
            {
                player2.IncrementLegs();
                Console.WriteLine(player2.GetName() + " wins the leg! Score: " + 
                                  player1.GetCurrentLegs() + "-" + player2.GetCurrentLegs());
                
                // Check if player2 won the match
                if (player2.GetCurrentLegs() >= player2.GetTargetLegs())
                {
                    Console.WriteLine("\n🎯 " + player2.GetName() + " WINS THE MATCH! 🎯");
                    break;
                }
            }
        }
    }
}
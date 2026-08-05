using System.Reflection.Metadata;

namespace rock_paper_scissors
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Random randon = new Random();

            int playerScore = 0;
            int enemyScore = 0;

            Console.WriteLine("Welcome to rock paper scissors!");
            Console.WriteLine("First person to win 3 points win!");

            while(playerScore != 3 && enemyScore != 3)
            {
                Console.WriteLine("Player score - " + playerScore + ". Enemy score - " + enemyScore);
                Console.WriteLine("Please enter 'r' for rock, 'p' for paper or anything else for scissors ");
                string playerChoice = Console.ReadLine();

                int enemyChoice = randon.Next(0, 3);

                if (enemyChoice == 0)
                {
                    Console.WriteLine("Enemy choose rock.");

                    switch (playerChoice)
                    {
                        case "r":
                            Console.WriteLine("Tie!");
                            break;
                        case "p":
                            Console.WriteLine("Player wins this round.");
                            playerScore++;
                            break;
                        default:
                            Console.WriteLine("Enemy wins this round.");
                            enemyScore++;
                            break;

                    }

                }
                else if (enemyChoice == 1) 
                {
                    Console.WriteLine("Enemy chooses paper.");

                    switch (playerChoice)
                    {
                        case "r":
                            Console.WriteLine("Enemy wins this round.");
                            enemyScore++;
                            break;
                        case "p":
                        default:
                            Console.WriteLine("Player wins this round.");
                            playerScore++;
                            break;

                    }
                }
                else
                {
                    Console.WriteLine("Enemy chooses scissors.");

                    switch (playerChoice)
                    {
                        case "r":
                            Console.WriteLine("Player wins this round.");
                            playerScore++;
                            break;
                        case "p":
                            Console.WriteLine("Enemy wins this round.");
                            enemyScore++;
                            break;
                        default:
                            Console.WriteLine("Tie!");
                            break;
                    }
                }
            }

            if (playerScore == 3)
            {
                Console.WriteLine("You win!");
            }
            else
            {
                Console.WriteLine( "You lose!");
            }
        }
    }
}

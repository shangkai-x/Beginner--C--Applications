using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace turn_based_combact_game
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int playerHP = 40;
            int enemyHP = 25;

            int playerAttack;
            int enemyAttack;

            int playerheal;
            int enemyheal;

            int player_accuracy;
            int enemy_accuracy;

            Random random = new Random();

            while(playerHP > 0 && enemyHP > 0)
            {
                // home page
                Console.WriteLine("-- Player turn --");
                Console.WriteLine("PLayer HP = " + playerHP  + ". Enemy HP = " + enemyHP );
                Console.WriteLine("Enter 'a' to attack or 'h' to heal.");
                
                // player and enemy stats
                string choice = Console.ReadLine();
                playerAttack = random.Next(5, 8);
                enemyAttack = random.Next(6, 9);
                playerheal = random.Next(5, 7);
                enemyheal = random.Next(5, 7);
                player_accuracy = random.Next(1, 11);
                enemy_accuracy = random.Next(1, 11);


                // player turn
                if (choice == "a" && player_accuracy > 3)
                {
                    enemyHP -= playerAttack;
                    Console.WriteLine("Player attack enemy and deals " + playerAttack + " damage! ");
                }
                else if (choice =="h")
                {
                    if (playerHP >= 50) // Max HP for the player
                    {
                        playerHP = 50;
                        Console.WriteLine("You are at max health");
                    }
                    else
                    {
                        playerHP += playerheal;
                        Console.WriteLine("Player restores " + playerheal + " health points! ");
                    }
                }
                else
                {
                    Console.WriteLine("You missed your attack!");
                }

                //enemy turn
                if (enemyHP > 0)
                {
                    Console.WriteLine("-- Enemy turn --");
                    Console.WriteLine("PLayer HP = " + playerHP + ". Enemy HP = " + enemyHP);
                    int enemyChoice = random.Next(0,2);

                    if(enemyChoice == 0 && enemy_accuracy > 4)
                    {
                        playerHP -= enemyAttack;
                        Console.WriteLine("Enemy attacks and deals " + enemyAttack + " damage!");
                    }
                    else if (enemyChoice == 0 && enemy_accuracy <= 4)
                    {

                        Console.WriteLine("Enemy missed their atttack");
                    }
                    else
                    {
                        if (enemyHP < 30) 
                        {
                            enemyHP += enemyheal;
                            Console.WriteLine("Enemy restores " + enemyheal + " health points!");
                        }
                        else
                        {
                            enemyHP = enemyHP + 1 ;
                            Console.WriteLine("Enemy restores 1 health points!");
                        }
                        
                    }
                }
            }
            //player win or lose
            if (playerHP > 0)
            {
                Console.WriteLine("Congulations, you have won!");
            }
            else
            {
                Console.WriteLine("You lose, maybe next time!");
            }
            Console.ReadLine();
        }
    }
}

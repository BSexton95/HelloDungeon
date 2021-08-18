using System;
using System.Collections.Generic;
using System.Text;

namespace HelloDungeon
{
    class Game
    {
        public void Run()
        {
            //
            /*int healthRegen = 50;
            int health = 100;
            health += healthRegen;
            Console.WriteLine(health);

            string name = "Empty";
            Console.WriteLine("Please enter your name. ");
            name = Console.ReadLine();
            Console.WriteLine("Hello " + name);
            */
            //Test commit

            string playerName = "Empty";
            float playerHealth = 100.0f;
            int level = 1;
            float enemyHealth = 100.0f;
            int playerAttackDamage1 = 30;
            int playerAttackDamage2 = 20;
            int enemyAttackDamage = 20;
            int inventory = 5;
            int lowLevelSwordDamage = 40;
            int lowLevelPistolDamage = 40;
            string weapon;
            bool playerDied;

            //Player enters there character name
            Console.WriteLine("What is your adventure name.");
            playerName = Console.ReadLine();
            //Console displays player name and welcomes them to the game
            Console.Write("Hello " + playerName);
            Console.WriteLine(", welcome to your first adventure!");

            Console.ReadKey();
            Console.Clear();

            //Get players input
            string input = Console.ReadLine();

            //Display player weapon choice
            Console.WriteLine("Please choose starting weapon.");
            Console.WriteLine("1.Sword");
            Console.WriteLine("2.Gun");

            if(input == "1" || input == "Sword")
            {
                weapon = "Sword";
                lowLevelSwordDamage = 40;
            }
            

            //Pick a job excersie
            
            //User job choices
            /*Console.WriteLine("Pick a job");
            Console.WriteLine("1.Wizard");
            Console.WriteLine("2.Knight");
            Console.Write(">");

            string characterJob = "Empty";
            string input = Console.ReadLine();

            //If player chooses wizard
            if (input == "1" || input == "wizard")
            {
                //Wizard Stats
                characterJob = "Wizard";
                playerHealth = 300;
                playerAttackDamage1 = 400;
            }
            //If player chooses knight
            else if (input == "2" || input == "knight")
            {
                //Knight Stats
                characterJob = "Knight";
                playerHealth = 300;
                playerAttackDamage2 = 400;
            }
            //If player chooses anything else
            else
            {
                //Players input was invalid
                Console.WriteLine("invalid input");
            }

            //Display players stats for player to see
            Console.WriteLine("Your character stats\n");
            Console.WriteLine("Character " + characterJob);
            Console.WriteLine("Name " + playerName);
            Console.WriteLine("Health " + playerHealth);
            Console.WriteLine("Power " + playerAttackDamage1);
            
            //Stops console for player to read stats. Player can press any key to move on.
            Console.ReadKey();
            //Clears stats from console.
            Console.Clear();*/

            //First area player enters
            Console.WriteLine("On your adventure you have stumbled into an abandoned village.");
            Console.WriteLine("As you are exploring this village you notice a dog huddled in a corner.");
            Console.WriteLine("Should you\n 1.Slowly approach the dog?\n 2.Ignore the dog?");

            input = Console.ReadLine();
            //If player chooses to approach dog
            if (input == "1" || input == "Slowly approach the dog")
            {
                //What happens when player approches dog
                Console.WriteLine("As you are slowly approaching the dog reaching out with your hand the dog starts to growl.");
                Console.WriteLine("You halt to reassess your decision");
                Console.WriteLine("Do you wish to continue forward?\n 1.Yes\n 2.No");

                input = Console.ReadLine();

                //If player continues to approach dog
                if (input == "1" || input == "Yes")
                {
                    //What happens when player contiues forward
                    Console.WriteLine("The dog stops growling and sniffs your hand.\nThe dog seems to like you.");
                    Console.WriteLine("Congratulations you now have a new bestfriend to travel along with you in your adventrue.");
                }
                //if player decides to turn back
                else if (input == "2" || input == "No")
                {
                    //What happens when player turns back
                    Console.WriteLine("As you start to turn away from the dog, the dog suddenly lunges forward and starts to attack you.");
                }
                else
                {
                    Console.WriteLine("invalid input");
                }
            }
            //If player ignores dog
            else if (input == "2" || input == "Ignore the dog")
            {
                //What happens to player if player ignores dog
                Console.WriteLine("The dog dosn't seem to notice as you walk by.");
            }
            else
            {
                Console.WriteLine("Invalid input");
            }
             




        }
    }
}

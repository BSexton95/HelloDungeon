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
            int inventory = 0;
            int lowLevelSwordDamage = 40;
            int lowLevelPistolDamage = 40;
            string weapon = "Empty";
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
            /* string input = Console.ReadLine();

             //Display player weapon choice
             Console.WriteLine("Please choose starting weapon.");
             Console.WriteLine("1.Sword");
             Console.WriteLine("2.Gun");

             if (input == "1" || input == "Sword")
             {
                 Console.WriteLine("")
                 weapon = "Sword (Damage 40)";
             }
             else if (input == "2" || input == "Gun") 
             {
                 weapon = "Gun (Damage 40)";
             }
             else
             {
                 Console.WriteLine("Invalid input");
             }

             Console.WriteLine("Character Stats");
             Console.WriteLine("Name " + playerName);
             Console.WriteLine("Weapon " + weapon);
             Console.WriteLine("Main Attack Damage " + playerAttackDamage1);
             Console.WriteLine("Secondary Attack Damage " + playerAttackDamage2);
             */



            //While loop exercise
            string characterJob = "Empty";
            string input = "Empty";
            
            //While loop condition declared
            bool validInputReceived = false;
            //While input is not valid, displays choices again
            while (validInputReceived == false)
            {
                //Pick a job excersie

                //User job choices
                Console.WriteLine("Pick a job");
                Console.WriteLine("1.Wizard");
                Console.WriteLine("2.Knight");
                Console.Write(">");

                //Gets player input
                input = Console.ReadLine();

                //If player chooses wizard
                if (input == "1" || input == "wizard")
                {
                    //Wizard Stats
                    characterJob = "Wizard";
                    playerHealth = 300;
                    playerAttackDamage1 = 400;
                    validInputReceived = true;
                }
                //If player chooses knight
                else if (input == "2" || input == "knight")
                {
                    //Knight Stats
                    characterJob = "Knight";
                    playerHealth = 300;
                    playerAttackDamage2 = 400;
                    validInputReceived = true;
                }
                //If player chooses anything else
                else
                {
                    //Players input was invalid
                    Console.WriteLine("invalid input");
                }
                
            }

            Console.ReadKey();
            Console.Clear();

            
            //Display players stats for player to see
            Console.WriteLine("Your character stats");
            Console.WriteLine("Character " + characterJob);
            Console.WriteLine("Name " + playerName);
            Console.WriteLine("Health " + playerHealth);
            Console.WriteLine("Power " + playerAttackDamage1);
            
            //Stops console for player to read stats. Player can press any key to move on.
            Console.ReadKey();
            //Clears stats from console.
            Console.Clear();

            //First area player enters
            Console.WriteLine("On your adventure you have stumbled into an abandoned village.");
            Console.WriteLine("As you are exploring this village you notice a dog huddled in a corner.");
            Console.WriteLine("Should you\n 1.Slowly approach the dog?\n 2.Ignore the dog?");
            Console.Write(">");

            input = Console.ReadLine();

           
            
                //If player chooses to approach dog
                if (input == "1" || input == "Slowly approach the dog")
                {
                    //What happens when player approches dog
                    Console.WriteLine("As you are slowly approaching the dog reaching out with your hand the dog starts to growl.");
                    Console.WriteLine("You halt to reassess your decision");
                    Console.WriteLine("Do you wish to continue forward?\n 1.Yes\n 2.No");
                    Console.Write(">");

                    //Get users input
                    input = Console.ReadLine();

                    //If player continues to approach dog
                    if (input == "1" || input == "Yes")
                    {
                        //What happens when player contiues forward
                        Console.WriteLine("The dog stops growling and sniffs your hand.\nThe dog seems to like you.");
                        Console.WriteLine("Congratulations you now have a new bestfriend to travel along with you in your adventrue.");
                        //Player enters dog name here
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
                
            Console.Clear();

            //For loop exercise

            //declare number of players attempts
            int numberOfAttempts = 4;

            Console.WriteLine("A very old man with a monkey on his back approaches you" +
                "\n The monkey offers you immortality if you can solve a riddle in " + numberOfAttempts + " attempts");

            Console.ReadKey();

            //For Loop
            for(int i = 0; i < numberOfAttempts; i++)
            {
                Console.Clear();
                Console.WriteLine("What has to be broken before you can use it?");
                int attemptsRemaining = numberOfAttempts - i;
                Console.WriteLine("Attempts Remaining: " + attemptsRemaining);
                Console.Write("> ");
                input = Console.ReadLine();

                if (input == "egg")
                {
                    Console.WriteLine("Congrats! You have gained immortality");
                    break;

                }

                Console.WriteLine("Incorrect! The monkey laughs at you. It hurts..." +
                    "\n you take 5 points of damage.");
                playerHealth -= 5;
            }

            Console.ReadKey();
            Console.Clear();

            //If player has the dog, this event will happen
            Console.WriteLine("You and your dog (name of dog, player will create, will be put here) have been traveling for about a week now" +
                "and have had many incounters with enemys." + "\n You have now stopped at a merchant store to replenish your stock of potions." +
                "\n You have a very limited amount of space and can only buy 2 items.");
            Console.WriteLine("Items in store" +
                "\n 1.Potion of healing +20 ($100)" + "\n 2.Poison" + "\n 3.Potion of Power");

            bool validInputRecieved = true;
            input = Console.ReadLine();

            while (validInputRecieved == false) 
            {
                if (input == "1" || input == "Potion of healing")
                {
                    Console.WriteLine("You have choosen Potion of Healing");
                    inventory = 1 + inventory;
                }
                else if (input == "2" || input == "Poison")
                {
                    Console.WriteLine("You have choosen Poison.");
                    inventory = 1 + inventory;
                }
                else if (input == "3" || input == "Potion of Power") 
                {
                    Console.WriteLine("You have choosen Potion of Power.");
                    inventory = 1 + inventory;
                }
                else
                {
                    Console.WriteLine("Invalid Input");
                }
            }



             




        }
    }
}

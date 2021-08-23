using System;
using System.Collections.Generic;
using System.Text;

namespace HelloDungeon
{
    class Game
    {
        string playerName = "Empty";
        int playerHealth = 100;
        //int level = 1;
        //float enemyHealth = 100.0f;
        int playerAttackDamage1 = 30;
        int playerAttackDamage2 = 20;
        //int enemyAttackDamage = 20;
        int inventory = 0;
        int sword = 40;
        int gun = 40;
        string weapon = "Empty";
        bool playerDied;
        string characterJob = "Empty";

        void DisplayPlayerStats()
        {
            Console.WriteLine("Character Stats");
            Console.WriteLine("Name " + playerName);
            Console.WriteLine("Health " + playerHealth);
            Console.WriteLine("Main Attack Damage " + playerAttackDamage1);
            Console.WriteLine("Secondary Attack Damage " + playerAttackDamage2);
        }

        void CharacterJob()
        {
            int input = GetInput("Pick a job!", "1.Wizard", "2.Knight");

            

            //If player chooses wizard
            if (input == 1)
            {
                //Wizard Stats
                characterJob = "Wizard";
                playerHealth = 300;
                playerAttackDamage1 = 400;
                
            }
            //If player chooses knight
            else if (input == 2)
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

        }


        void Interaction1()
        {
            //First interaction
           int input = GetInput("On your adventure you have stumbled into an abandoned village." +
                "\n As you are exploring this village you notice a dog huddled in a corner." + 
                "\n Should you ", "1.Slowly approach the dog?", "2.Ignore the dog?");
 
            //If player chooses to approach dog
            if (input == 1)
            {
                //What happens when player approches dog
                input = GetInput("You are slowly approaching the dog reaching out with your hand the dog starts to growl." +
                    "\n You halt to reassess your decision" + "\n Do you wish to continue forward?", "1.Yes", "2.No");
                


                //If player continues to approach dog
                if (input == 1)
                {
                    //What happens when player contiues forward
                    Console.WriteLine("The dog stops growling and sniffs your hand.\nThe dog seems to like you.");
                    Console.WriteLine("Congratulations you now have a new bestfriend to travel along with you in your adventrue.");
                    //Player enters dog name here
                }
                //if player decides to turn back
                else if (input == 2)
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
            else if (input == 2)
            {
                //What happens to player if player ignores dog
                Console.WriteLine("The dog dosn't seem to notice as you walk by.");
            }
            else
            {
                Console.WriteLine("Invalid input");
            }
            Console.ReadKey();
            Console.Clear();
        }



        /// <summary>
        /// 
        /// </summary>
        /// <param name="description"></param>
        /// <param name="option1"></param>
        /// <param name="option2"></param>
        /// <returns></returns>
        int GetInput(string description, string option1, string option2)
        { 
            string input = "";
            int inputReceived = 0;

            //Loops if player enters invalid input
            while (!(inputReceived == 1 || inputReceived == 2))
            {
                Console.WriteLine(description);
                Console.WriteLine("1. " + option1);
                Console.WriteLine("2. " + option2);
                Console.Write(">");

                //Get player input
                input = Console.ReadLine();

                if (input == "1" || input == option1)
                {
                    //Set input received to be the first option
                    inputReceived = 1;
                    Console.WriteLine(option1);
                    
                }
                //Otherwise if the player selected the second option...
                else if (input == "2" || input == option2)
                {
                    //Set input received to be the second option
                    inputReceived = 2;
                    Console.WriteLine(option2);
                    
                }
                //Of neither are true...
                else
                {
                    //Display error message
                    Console.WriteLine("Invalid input");
                }

                Console.ReadKey();
                Console.Clear();
            }
            return inputReceived;
        }


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

            /*string playerName = "Empty";
            float playerHealth = 100.0f;
            int level = 1;
            float enemyHealth = 100.0f;
            int playerAttackDamage1 = 30;
            int playerAttackDamage2 = 20;
            int enemyAttackDamage = 20;
            int inventory = 0;
            int sword = 40;
            int gun = 40;
            string weapon = "Empty";
            bool playerDied;
            string characterJob = "Empty";
            */


            //Player enters there character name
            Console.WriteLine("What is your adventure name.");
            playerName = Console.ReadLine();

            //Console displays player name and welcomes them to the game
            Console.Write("Hello " + playerName);
            Console.WriteLine(", welcome to your first adventure!");

            Console.ReadKey();
            Console.Clear();

            //Get players input
            //string input = GetInput();

            //Display player weapon choice
            //Console.WriteLine("Please choose starting weapon.");
            //Console.WriteLine("1.Sword");
            //Console.WriteLine("2.Gun");

            //Calling GetInput for player to choose a weapon
            GetInput("Weapon Choice", "Sword", "Gun");

            DisplayPlayerStats();
            CharacterJob();
            Console.ReadKey();
            Console.Clear();

             Interaction1();

        

            //While loop exercise
            //string characterJob = "Empty";
            //string input = "Empty";
            /*
            //While loop condition declared
            bool validInputReceived = false;
            /* Note
                !A && !B
                !(A || B)
            /*
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
                playerInput = Console.ReadLine();

                //If player chooses wizard
                if (playerInput == "1" || playerInput == "wizard")
                {
                    //Wizard Stats
                    characterJob = "Wizard";
                    playerHealth = 300;
                    playerAttackDamage1 = 400;
                    validInputReceived = true;
                }
                //If player chooses knight
                else if (playerInput == "2" || playerInput == "knight")
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
                playerInput = Console.ReadLine();   

                if (playerInput == "egg")
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
            string playerInput = Console.ReadLine();

            while (validInputRecieved == false) 
            {
                if (playerInput == "1" || playerInput == "Potion of healing")
                {
                    Console.WriteLine("You have choosen Potion of Healing");
                    inventory = 1 + inventory;
                }
                else if (playerInput == "2" || playerInput == "Poison")
                {
                    Console.WriteLine("You have choosen Poison.");
                    inventory = 1 + inventory;
                }
                else if (playerInput == "3" || playerInput == "Potion of Power") 
                {
                    Console.WriteLine("You have choosen Potion of Power.");
                    inventory = 1 + inventory;
                }
                else
                {
                    Console.WriteLine("Invalid Input");
                }
            }*/



             




        }
    }
}

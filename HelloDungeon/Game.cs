using System;
using System.Collections.Generic;
using System.Text;

namespace HelloDungeon
{
    class Game
    {
        string playerName = "Empty";
        int playerHealth = 100;
        int playerPower = 100;
        //float enemyHealth = 100.0f;
        int playerAttackDamage = 30;
        //int enemyAttackDamage = 20;
        int sword = 40;
        int gun = 40;
        string weapon = "Empty";
        bool playerDied;
        string characterClass = "Empty";

        //Display players stats
        void DisplayPlayerStats()
        {
            Console.WriteLine("Character Stats");
            Console.WriteLine("Name " + playerName);
            Console.WriteLine("Class " + characterClass);
            Console.WriteLine("Weapon " + weapon);
            Console.WriteLine("Health " + playerHealth);
            Console.WriteLine("Power " + playerPower);
            Console.WriteLine("Main Attack Damage " + playerAttackDamage);
        }

        /// <summary>
        /// This function allows player to choose a class
        /// </summary>
        void CharacterClass()
        {
            int input = GetInput("Pick a class!", "Warlock", "Elf");

            //If player chooses wizard
            if (input == 1)
            {
                //Wizard Stats
                characterClass = "Warlock";
                playerHealth = 100;
                playerAttackDamage = 30;
                
            }
            //If player chooses knight
            else if (input == 2)
            {
                //Knight Stats
                characterClass = "Elf";
                playerHealth = 100;
                playerAttackDamage = 30;
            }
            //If player chooses anything else
            else
            {
                //Players input was invalid
                Console.WriteLine("invalid input");
            }
            Console.ReadKey();
            Console.Clear();

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

        void Interaction2()
        {
            //declare number of players attempts
            int numberOfAttempts = 4;
            string input = " ";

            Console.WriteLine("A very old man with a monkey on his back approaches you" +
                "\n The monkey offers you immortality if you can solve a riddle in " + numberOfAttempts + " attempts");

            Console.ReadKey();

            //For Loop
            for (int i = 0; i < numberOfAttempts; i++)
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

        }
        
        /*
        void FinalInteraction()
        {
            int input = GetInput("After picking a potion you continue on your adventure" +
                "\n "
        }
        */
        /// <summary>
        /// Player stops at a merchant shop to choose if they want to replenish their health or power
        /// </summary>
        void MerchantStop()
        {
            playerHealth = 50;
            playerPower = 50;

            int input = GetInput("You have been traveling for about a week now and have had many incounters with enemys." +
                "\n Due to these incounters you have lost 50 health and 50 power." +
                "\n You have stopped at a merchant store to replenish but" +
                "\n unfortantly you have a very limited amount of space and can only buy 1 item." +
                "\n Items in stock: ", "1.Potion of Healing", "2. Potion of Power");

            if (input == 1)
            {
                Console.WriteLine("You have choosen Potion of Healing");
                playerHealth = 50 + playerHealth;
               
            }
            else if (input == 2)
            {
                Console.WriteLine("You have choosen Poison.");
                playerPower = 50 + playerHealth;
            }
            else
            {
                Console.WriteLine("Invalid Input");
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
            //Player enters there character name
            Console.WriteLine("What is your adventure name.");
            playerName = Console.ReadLine();

            //Console displays player name and welcomes them to the game
            Console.Write("Hello " + playerName);
            Console.WriteLine(", welcome to your first adventure!");

            Console.ReadKey();
            Console.Clear();


            //Calling GetInput for player to choose a weapon
            GetInput("Weapon Choice", "Sword", "Gun");

            //Calling function that lets player choose a class
            CharacterClass();
            //Calling function to display players stats after chooseing a class
            DisplayPlayerStats();
          
            //Player finds a dog interaction
            Interaction1();

            //Player finds a man with a riddle interaction
            Interaction2();

            //Player will choose between a healing potion and a power potion
            MerchantStop();

            //Displays player stats after choosing a potion
            DisplayPlayerStats();
        }
    }
}

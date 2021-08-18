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
            float playerHeath = 100.0f;
            int level = 1;
            float enemyHealth = 100.0f;
            int playerAttackDamage1 = 30;
            int playerAttackDamage2 = 20;
            int enemyAttackDamage = 20;
            int inventory = 5;
            int lowLevelSwordDamage = 40;
            int lowLevelPistolDamage = 40;

            Console.WriteLine("What is your adventure name.");
            playerName = Console.ReadLine();
            Console.Write("Hello " + playerName);
            Console.WriteLine(", welcome to your first adventure!");

            //Console.WriteLine("Please choose starting weapon.");
            // Code to display weapon choices
            // Code for users weapon selection
        }
    }
}

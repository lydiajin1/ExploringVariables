namespace ExploringVariables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Variables
            string heroFirstName = "Lydia";
            string heroLastName = "Jin";
            string heroFullName;
            string villainTitle = "Evil Madam";
            string minionTitle = "The Henchmen"; 
            string villainName;
            string minion1Name;
            string minion2Name;

            int heroHealth = 100;
            int heroStrength = 50;
            int bossHealth = 100;
            int bossStrength = 25;
            int minion1Health = 50;
            int minion2Health = 50;
            int minionStrength = 5;


            //Begin Code Instructions 
            heroFullName = heroFirstName + " " + heroLastName;

            Console.WriteLine("Behold the legendary hero of programming, whose name is: " + heroFullName);

            villainName = "Cruella";
            minion1Name = "Bob";
            minion2Name = "Stuart";

            Console.WriteLine(heroFullName + "'s arch rival is " + villainName + " the " + villainTitle);

            //evil madam's minions!
            Console.WriteLine(villainName + " the " + villainTitle + " is helped out by: " + minionTitle + " " + minion1Name + " and " + minionTitle + " " + minion2Name);

            //Are you prepared to fight? 
            Console.WriteLine("The fight of all time is about to begin!");
            Console.WriteLine("Hero's health: " + heroHealth);
            Console.WriteLine("Boss's health: " + bossHealth);
            Console.WriteLine("Minion 1's health: " + minion1Health);
            Console.WriteLine("Minion 2's health: " + minion2Health);

            //Time to fight! 
            //Boss attacks first 
            Console.WriteLine(villainName + " the " + villainTitle + " attacks " + heroFullName);
            Console.WriteLine(villainName + " the " + villainTitle + " deals " + bossStrength + " damage!");
            //Hero's health subtract by damage by villain 
            heroHealth = heroHealth - bossStrength;
            Console.WriteLine(heroFullName + " now has " + heroHealth + " health!");
            //Minions attack
            Console.WriteLine("The evil Henchmens attack!");
            Console.WriteLine(minion1Name + " deals " + minionStrength + " damage!");
            //Hero's health subtract by damage by minions
            heroHealth = heroHealth - minionStrength;
            Console.WriteLine(heroFullName + " now has " + heroHealth + " health!");
            Console.WriteLine(minion2Name + " deals " + minionStrength + " damage!");
            //Hero's health subtract by damage by minions
            heroHealth = heroHealth - minionStrength;
            Console.WriteLine(heroFullName + " now has " + heroHealth + " health!");

            //Hero turn to attack 
            Console.WriteLine(heroFullName + " attacks each villain for " + heroStrength + " damage!");
            //Current health subtract damaage by hero 
            bossHealth -= heroStrength;
            minion1Health -= heroStrength;
            minion2Health -= heroStrength;

            //Display Results 
            Console.WriteLine(villainName + " the " + villainTitle + " now has " + bossHealth + " health!");
            Console.WriteLine(minionTitle + " " + minion1Name + " now has " + minion1Health + " health!");
            Console.WriteLine(minionTitle + " " + minion2Name + " now has " + minion2Health + " health!");

            //The minions have been defeated!
            Console.WriteLine(minion1Name + " and " + minion2Name + " have been defeated!");

            //End of round
            Console.WriteLine(heroFullName + " has " + heroHealth + " health");
            Console.WriteLine(heroFullName + " eats a watermelon to restore health!");
            heroHealth++;
            Console.WriteLine(heroFullName + " now has " + heroHealth + " health!");

            //final round 
            Console.WriteLine("The remaining fighters continue the fight!");
            Console.WriteLine("Hero's health: " + heroHealth);
            Console.WriteLine("Boss's health: " + bossHealth);
            //Boss attacks first
            Console.WriteLine(villainName + " the " + villainTitle + " attacks " + heroFullName);
            Console.WriteLine(villainName + " the " + villainTitle + " deals " + bossStrength + " damage!");
            //Hero's health subtract by damage by villain 
            heroHealth = heroHealth - bossStrength;
            Console.WriteLine(heroFullName + " now has " + heroHealth + " health!");
            //Hero turn to attack!
            Console.WriteLine(heroFullName + " attacks " + villainName + " the " + villainTitle + " for " + heroStrength + " damage!");
            bossHealth = bossHealth - heroStrength;

            //Display results 
            Console.WriteLine(villainName + " the " + villainTitle + " now has " + bossHealth + " health!");

            //Results
            Console.WriteLine(heroFullName + " is victorious!");
            Console.WriteLine("May the grand, glory, and greatness belong to the winner!");

        }
    }
}



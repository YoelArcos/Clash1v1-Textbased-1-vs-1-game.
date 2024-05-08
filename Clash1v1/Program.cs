using System.Xml.Linq;

namespace Clash1v1
{
    public class GameApp
    {
        public static void Main(string[] args)
        {

            Console.WriteLine("Welcome to the Battle!!!");
            Console.WriteLine("________________________");

            Console.WriteLine("Choose your Fighter:");
            Console.WriteLine("1. Barbarian (85HP, 12AD, 5H) ");
            Console.WriteLine("2. Knight (90HP, 11AD, 7H)");
            Console.WriteLine("3. Samurai (70HP, 20AD, 4H)");
            int playerChoice = int.Parse(Console.ReadLine());

            
            Player player = null;

            // to get the selected fighter as an Object 
            switch (playerChoice)
            {
                case 1:
                    player = new Player("Barbarian", 85, 12, 5);
                    break;

                case 2:
                    player = new Player("Knight", 90, 11, 7);
                    break;

                case 3:
                    player = new Player("Samurai", 70, 20, 4);
                    break;

                default:
                    Console.WriteLine("Invalid fighter selected, defaulting to Barbarian");
                    player = new Player("Barbarian", 85, 12, 5);
                    break;
            }


            Console.WriteLine("Choose your Enemy:");
            Console.WriteLine("1. Magician (65HP, 18AD, 10H) ");
            Console.WriteLine("2. Dark-Knight (88HP, 10AD, 10H)");
            Console.WriteLine("3. Ninja (67HP, 16AD, 4H");
            int enemyChoice = int.Parse(Console.ReadLine());

            Enemy enemy = null;

            switch (enemyChoice)
            {
                case 1:
                    enemy = new Enemy("Magician", 65, 18, 10);
                    break;

                case 2:
                    enemy = new Enemy("Dark-Knight", 88, 10, 10);
                    break;

                case 3:
                    enemy = new Enemy("Ninja", 67, 16, 4);
                    break;

                default:
                    Console.WriteLine("Invalid Fighter selected, defaulting to Magician");
                    enemy = new Enemy("Magician", 65, 18, 10);
                    break;
            }

            while (player.UnitHealth > 0 && enemy.EnemyHealth > 0)
            {
                
                Console.WriteLine(player.UnitName + " " +player.UnitHealth + " HP "+ "VS. " + enemy.UnitName + " " + enemy.EnemyHealth + " HP\n");

                Console.WriteLine("Player's turn \n");
                Console.WriteLine("> Options: 'a' to attack, 'h' to heal");
                string choice = Console.ReadLine();

                if (choice == "a")
                {
                    Console.WriteLine("");
                    player.startAttack(enemy);
                } else if (choice == "h")
                {
                    Console.WriteLine("");
                    player.startHeal();
                }

                Console.WriteLine("Enemy's turn \n");
                enemy.DecideAction(player);


            }

            if (player.UnitHealth > 0)
            {
                Console.WriteLine(player.UnitName + " has won the battle.");
            }
            else
            {
                Console.WriteLine(enemy.UnitName + " has won the battle.");
            }


            Console.WriteLine("");
            Console.WriteLine("Press a random button to finish the game.");
            Console.ReadLine();


        }
    }
}
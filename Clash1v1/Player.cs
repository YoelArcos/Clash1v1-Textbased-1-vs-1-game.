using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Clash1v1
{
    internal class Player
    {
        public string UnitName { get; set; }
        public double UnitHealth { get; set; }
        public double PlayerAttack { get; set; }
        public int Heal {  get; set; }

        public Player(string unitName,double unitHealth, double playerAttack, int heal) 
        { 
            this.UnitName = unitName;
            this.UnitHealth = unitHealth;
            this.PlayerAttack = playerAttack;  
            this.Heal = heal;
        }

        public void startAttack(Enemy enemy)
        {
            Random rnd = new Random();
            double criticalDamage = rnd.Next(1, 5);

            if (criticalDamage == 3)
            {
                double playerAttackCritical = PlayerAttack;

                playerAttackCritical *= 1.25f;
                enemy.EnemyHealth -= playerAttackCritical;

                Console.WriteLine("Critical Damage that made " + playerAttackCritical + " damage to " + enemy.UnitName);
                Console.WriteLine("");
            } else
            {
                enemy.EnemyHealth -= PlayerAttack;
                Console.WriteLine("You started an attack, that made " + PlayerAttack + " damage to " + enemy.UnitName);
                Console.WriteLine("");
            }

            
        }

        public void startHeal()
        {
            UnitHealth += Heal;
            Console.WriteLine("Your health increased by: " + Heal + " points!");
            Console.WriteLine("");
        }
    }
}
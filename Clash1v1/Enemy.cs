using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clash1v1
{
    internal class Enemy 
    {
        public string UnitName {  get; set; }
        public double EnemyHealth {  get; set; }
        public double EnemyAttack {  get; set; }
        public int Heal { get; set; }

        public Enemy(string unitName, double enemyHealth, double enemyAttack, int heal)
        {
            this.UnitName = unitName;
            this.EnemyHealth = enemyHealth;   
            this.EnemyAttack = enemyAttack;
            this.Heal = heal;
        }
        public void EnemyStartAttack(Player player)
        {
            player.UnitHealth -= EnemyAttack;

            Console.WriteLine(UnitName + " attacked you and made " + EnemyAttack + " damage");
        }

        public void EnemyHeal()
        {
            EnemyHealth += Heal;
            
        }

        // Der Feind entscheidet selbst ~
        public void DecideAction(Player player)
        {
            if ( EnemyHealth < 30 && EnemyHealth >0)
            {
                EnemyHeal();
                Console.WriteLine("");
                Console.WriteLine(UnitName + " healed himself " + Heal +" points.");
            } else
            {
                EnemyStartAttack(player);
            }
        }
    }
}

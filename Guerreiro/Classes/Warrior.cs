using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Guerreiro.Classes
{
    internal class Warrior
    {
        private int health;
        private string name;
        private bool isAlive;
        private Faction faction;
        private Armor armor;
        private Weapon weapon;
        private static readonly int GOOD_GUY_STARTING_HEALTH = 100;
        private static readonly int BAD_GUY_STARTING_HEALTH = 90;

        public Armor Armor { get { return armor; } }

        public Warrior(string name, Faction faction)
        {
            this.name = name;
            isAlive = true;
            armor = new Armor(faction);
            weapon = new Weapon(faction);
            if (faction == Faction.goodGuy)
            {
                health = GOOD_GUY_STARTING_HEALTH;
            }
            else if (faction == Faction.badGuy)
            {
                health = BAD_GUY_STARTING_HEALTH;
            }
        }

        private void attacked(Warrior warrior, int damage)
        {
            if(isAlive)
            {
                warrior.health -= damage;
                if(warrior.health <= 0)
                {
                    warrior.isAlive = false;
                }
            }
        }

        public void attack(Warrior enemy)
        {   
            if(enemy.isAlive && this.isAlive)
            {
                Random rand = new Random();
                if(rand.NextDouble() >= 0.5 && enemy.Armor.ArmorPoints > 0)
                {
                    enemy.Armor.ArmorPoints -= this.weapon.Damage;
                    Console.WriteLine($"{this.name}'s shot hit the enemy's armor.\n" + $"{enemy.name} current health: {enemy.health}.\n" + $"{enemy.name} current armor: {enemy.Armor.ArmorPoints}.\n" + new string('-', 40) + "\n");
                }
                else
                {   
                    enemy.health -= this.weapon.Damage;
                    if (enemy.health <= 0)
                    {
                        enemy.isAlive = false;
                        Console.WriteLine($"{this.name} attacked {enemy.name} for {this.weapon.Damage}.\n" + $"{this.name}'s shot eliminated {enemy.name}.\n" + $"{enemy.name} is dead.\n" + new string('-', 40) + "\n");
                    }
                    else
                    {
                        Console.WriteLine($"{this.name} attacked {enemy.name} for {this.weapon.Damage}.\n" + $"{this.name} current health: {this.health}.\n" + $"{enemy.name} current health: {enemy.health}.\n" + new string('-', 40) + "\n");
                    }
                }
            }
            else if (!enemy.isAlive)
            {
                Console.WriteLine($"{enemy.name} isn't alive.");
            }
            else
            {
                Console.WriteLine($"{this.name}, you're already dead.");
            }
        }


    }
}

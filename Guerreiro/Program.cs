using Guerreiro.Classes;

Warrior warrior = new Warrior("Vitor", Faction.goodGuy);

Warrior enemy = new Warrior("Victor", Faction.badGuy);

warrior.attack(enemy);
enemy.attack(warrior);
warrior.attack(enemy);
enemy.attack(warrior);
warrior.attack(enemy);
enemy.attack(warrior);
warrior.attack(enemy);
enemy.attack(warrior);
warrior.attack(enemy);
enemy.attack(warrior);


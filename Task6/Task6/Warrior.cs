using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task6
{
    class Warrior : GameCharacter
    {
        public Warrior(string name, int health) : base(name, health)
        {
            Console.WriteLine($"Warrior {name} enters the game!");
        }

        public override void UseSpecialAbility()
        {
            Console.WriteLine("The Warrior attacks with a sword!");
        }

        public override void TakeDamage(int amount)
        {
            int reduced = amount - 2;         
            if (reduced < 0) reduced = 0;
            Health -= reduced;
            Console.WriteLine($"{Name} takes {reduced} damage.");
        }
    }
}

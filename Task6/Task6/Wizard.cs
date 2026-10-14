using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task6
{
    class Wizard : GameCharacter
    {
        public Wizard(string name, int health) : base(name, health)
        {
            Console.WriteLine($"Wizard {name} enters the game!");
        }

        public override void UseSpecialAbility()
        {
            Console.WriteLine("The Wizard uses magic!");
        }
        public override void TakeDamage(int amount)
        {
            Health -= amount;
            Console.WriteLine($"{Name} takes {amount} damage.");
        }

    }
}
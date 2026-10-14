using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Adventure Game :");
            Warrior Sara = new Warrior("Sara", 90);
            Wizard Doha = new Wizard("Doha", 80);
            List<GameCharacter> characters = new List<GameCharacter> { Sara, Doha };

            foreach (var c in characters)
                c.UseSpecialAbility();

           
            Sara.TakeDamage(10);                       
            Console.WriteLine($"{Sara.Name}'s health: {Sara.CurrentHealth}");
            Sara.Heal();                               
            Sara.Heal(15);                            

            Doha.TakeDamage(10);                      
            Console.WriteLine($"{Doha.Name}'s health: {Doha.CurrentHealth}");

           
            HealthPotion potion = new HealthPotion("Red Potion");
            potion.collect();

            potion.Use(Doha, "15");                   
            Console.WriteLine($"{Doha.Name}'s health: {Doha.CurrentHealth}");

            potion.Use(Doha, "abc");                   
        }
    }
}
  

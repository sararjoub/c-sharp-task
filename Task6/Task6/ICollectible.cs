using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task6
{
     interface ICollectible
    {
        void collect();
    }
    class HealthPotion : ICollectible
    {
        public string PotionName { get; set; }
        public HealthPotion(string name)
        {
            PotionName = name;
        }
        public void collect()
        {
            Console.WriteLine($" HealthPotion : {PotionName}");
        }
        public void Use(GameCharacter character, string amountText)
        {
            try
            {
                int amount = Convert.ToInt32(amountText);
                character.Heal(amount);
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid input! Please enter a number.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }
    }
}


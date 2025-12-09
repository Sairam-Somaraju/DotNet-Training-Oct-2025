using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21_11_25
{
    public class GameCharacter
    {
        public int Health { get; set; }
        public int Attack { get; set; }
        public int Defense { get; set; }
        public List<string> Skills { get; set; }
        public GameCharacter Clone()
        {
            return new GameCharacter
            {
                Health = this.Health,
                Attack = this.Attack,
                Defense = this.Defense,
                Skills = new List<string>(this.Skills)
            };
        }
        public void ShowInfo(string name)
        {
            Console.WriteLine($"--- {name} ---");
            Console.WriteLine($"Health: {Health}, Attack: {Attack}, Defense: {Defense}");
            Console.WriteLine("Skills: " + string.Join(", ", Skills));
            Console.WriteLine();
        }
    }
    internal class GameCharacterMainMethod
    {
        static void Main(string[] args)
        {
            GameCharacter warriorPrototype = new GameCharacter
            {
                Health = 100,
                Attack = 20,
                Defense = 15,
                Skills = new List<string> { "Slash", "Block" }
            };

            GameCharacter warrior1 = warriorPrototype.Clone();
            GameCharacter warrior2 = warriorPrototype.Clone();

            warrior2.Skills.Add("Power Strike");

            warriorPrototype.ShowInfo("Base Warrior Prototype");
            warrior1.ShowInfo("Warrior Unit 1");
            warrior2.ShowInfo("Warrior Unit 2");
        }
    }
}

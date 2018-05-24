using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterManager
{
    class Character
    {
        private String Name, CharClass;
        private int Strength;
        private int Dexterity;
        private int Constitution;
        private int Intelligence;
        private int Wisdom;
        private int Charisma;
        private int BaseAttackBonus;
        private int SpellsPerDay1;
        private String FilePath;
        
        public Character()
        {

        }

        public Character(String filePath)
        {
            FilePath1 = filePath;
        }

        public Character(String Name, int Level, String Class) : this()
        {
            Level1 = Level;
            Name1 = Name;
            CharClass1 = Class;
        }

        public int Level1 { get; set; }
        public string Name1 { get => Name; set => Name = value; }
        public string CharClass1 { get => CharClass; set => CharClass = value; }
        public int Dexterity1 { get => Dexterity; set => Dexterity = value; }
        public int SpellsPerDay11 { get => SpellsPerDay1; set => SpellsPerDay1 = value; }
        public int BaseAttackBonus1 { get => BaseAttackBonus; set => BaseAttackBonus = value; }
        public int Charisma1 { get => Charisma; set => Charisma = value; }
        public int Wisdom1 { get => Wisdom; set => Wisdom = value; }
        public int Intelligence1 { get => Intelligence; set => Intelligence = value; }
        public int Constitution1 { get => Constitution; set => Constitution = value; }
        public int Strength1 { get => Strength; set => Strength = value; }
        public String FilePath1 { get => FilePath; set => FilePath = value; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DnDCharacterCreator.Repository
{
    public enum ClassType {barbarian, bard, cleric, druid, fighter, monk, paladin, ranger, rogue, sorcerer, warlock, wizard}
    public enum RaceType {dragonborn, dwarf, elf, gnome, half_elf, halfling, half_orc, human, tiefling}
    public class Character
    {
        public string Name {get; set;}
        public ClassType ClassName {get; set;}
        public int Lvl {get; set;}
        public RaceType Race {get; set;}
        public int Stgth {get; set;}
        public int Dex {get; set;}
        public int Const {get; set;}
        public int Int {get; set;}
        public int Wisd {get; set;}
        public int Char {get; set;}
        public bool NewCharacter {get; set;}

        public Character()
        {
            //empty constructor
        }

        public Character(string name, ClassType className, int lvl, RaceType race, int strgth, int dex, int cont, int intel, int wisd, int chari, bool newchar)
        {
            Name = name;
            ClassName = className;
            Lvl = lvl;
            Race = race;
            Stgth = strgth;
            Dex = dex;
            Const = cont;
            Int = intel;
            Wisd= wisd;
            Char = chari;
            NewCharacter = newchar;
        }
    }
}
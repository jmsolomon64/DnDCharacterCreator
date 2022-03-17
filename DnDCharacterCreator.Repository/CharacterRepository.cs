using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DnDCharacterCreator.Repository
{
    public class CharacterRepository
    {
        List<Character> _charList = new List<Character>();
        //CRUD METHODS
        //Create
        public void AddCharToList(Character character)
        {
            _charList.Add(character);
        }

        //Read
        public List<Character> GetAllCharacters()
        {
            return _charList;
        }

        public Character GetCharacterByName(string name)
        {
            foreach (Character character in _charList)
            {
                if (character.Name.ToUpper() == name.ToUpper())
                {
                    return character;
                }
            }
            return null;
        }

        //Update
        public bool UpdateCharacter(Character character)
        {
            foreach(Character existingCharacter in _charList) 
            { //^^ Goes through the whole database of characters
                if(existingCharacter.Name.ToUpper() == character.Name.ToUpper())
                { //^^Checks to see if one of the characters in the database matches the name of updated character
                    existingCharacter.Name = character.Name;
                    existingCharacter.ClassName = character.ClassName;
                    existingCharacter.Lvl = character.Lvl;
                    existingCharacter.Race = character.Race;
                    existingCharacter.Stgth = character.Stgth;
                    existingCharacter.Dex = character.Dex;
                    existingCharacter.Const = character.Const;
                    existingCharacter.Int = character.Int;
                    existingCharacter.Wisd = character.Wisd;
                    existingCharacter.Char = character.Char;

                    return true;
                }
            }
            return false;
        }

        //Delete

        public bool DeleteByCharName(string name)
        { //by calling for a bool we can change behavior of the program based on whether task was success or not
            foreach (Character character in _charList)
            { //itterates through character database 
                if (character.Name.ToUpper() == name.ToUpper())
                { // through each itteration checks to see if the characters name matches string 
                    _charList.Remove(character); //deletes character whose name matches string name
                    return true;
                }
            }

            return false;
        }


        //Seed data
        public void SeedData()
        {
            Character juno = new Character("Juno", ClassType.fighter, 2, RaceType.dwarf, 15, 15, 16, 12, 11, 10, false);
            Character luna = new Character("Luna", ClassType.bard, 3, RaceType.elf, 13, 15, 15, 16, 16, 18, false);
            Character gerald = new Character("Gerald", ClassType.druid, 4, RaceType.human, 14, 15, 16, 17, 17, 14, false);
            Character inky = new Character("Inky", ClassType.rogue, 1, RaceType.gnome, 13, 15, 14, 14, 13, 18, true);

            Character[] charArray = {juno, luna, gerald, inky};

            foreach (Character character in charArray)
            {
                AddCharToList(character);
            }
        }
    }
}
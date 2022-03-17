using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DnDCharacterCreator.Repository;

namespace DnDCharacterCreator.ConsoleApp
{
    public class UserInterface
    {
        CharacterRepository _charRepo = new CharacterRepository(); //Instance of repo class
        ConsoleEN _english = new ConsoleEN();

        

        bool isRunning = true; //bool to control execution of program

        public void Run()
        {
            _charRepo.SeedData();
            while (isRunning)
            {
                _english.Welcome();

                _english.MainMenu();
                string userChoice = GetUserInput();
                MainMenuSwitch(userChoice);
            }
        }

        public string GetUserInput()
        {
            string userInput = Console.ReadLine();
            return userInput;
        }

        private void CreateCharacter()
        {
            _english.EnterName();
            string name = GetUserInput();

            _english.EnterClass();
            string classChoice = GetUserInput();
            ClassType className = ClassSwitch(classChoice);
            
            _english.EnterLevel();
            int lvl = Convert.ToInt32(GetUserInput());

            _english.EnterRace();
            string raceChoice = GetUserInput();
            RaceType race = RaceSwitch(raceChoice);

            _english.EnterStatPoint(0);
            int strength = Convert.ToInt32(GetUserInput());

            _english.EnterStatPoint(1);
            int dex = Convert.ToInt32(GetUserInput());

            _english.EnterStatPoint(2);
            int constit = Convert.ToInt32(GetUserInput());

            _english.EnterStatPoint(3);
            int intel = Convert.ToInt32(GetUserInput());

            _english.EnterStatPoint(4);
            int wisd = Convert.ToInt32(GetUserInput());

            _english.EnterStatPoint(5);
            int charis = Convert.ToInt32(GetUserInput());

            _english.NewCharacter();
            string newchoice = GetUserInput();
            bool newPlayer = NewPlayerSwitch(newchoice);

            Character newCharacter = new Character(name, className, lvl, race, strength, dex, constit, intel, wisd, charis, newPlayer);

            _charRepo.AddCharToList(newCharacter);

            _english.CharacterCreated(name);
            _english.PressAnyKey();
            Console.ReadKey();
        }

        private void ViewCharacter()
        {
            _english.EnterName();
            string name = GetUserInput();

            Character character = _charRepo.GetCharacterByName(name);
            if (character != null)
            {
                _english.PrintCharacter(character);
                _english.PressAnyKey();
            } else {
                _english.CharacterNotFound();
                _english.PressAnyKey();
            }
                Console.ReadKey();
        }

        private void ViewAllCharacters()
        {
            List<Character> allCharacters = _charRepo.GetAllCharacters();
            foreach (Character character in allCharacters)
            {
                _english.PrintCharacter(character);
            }
            _english.PressAnyKey();
            Console.ReadKey();
        }

        private void EditCharacter()
        {
            _english.EnterName();
            string name = GetUserInput();

            Character character = _charRepo.GetCharacterByName(name);

            if (character != null)
            {
                _english.PrintCharacter(character);

                _english.EnterName();
                string newName = GetUserInput();

                _english.EnterClass();
                string classChoice = GetUserInput();
                ClassType className = ClassSwitch(classChoice);
                
                _english.EnterLevel();
                int lvl = Convert.ToInt32(GetUserInput());

                _english.EnterRace();
                string raceChoice = GetUserInput();
                RaceType race = RaceSwitch(raceChoice);

                _english.EnterStatPoint(0);
                int strength = Convert.ToInt32(GetUserInput());

                _english.EnterStatPoint(1);
                int dex = Convert.ToInt32(GetUserInput());

                _english.EnterStatPoint(2);
                int constit = Convert.ToInt32(GetUserInput());

                _english.EnterStatPoint(3);
                int intel = Convert.ToInt32(GetUserInput());

                _english.EnterStatPoint(4);
                int wisd = Convert.ToInt32(GetUserInput());

                _english.EnterStatPoint(5);
                int charis = Convert.ToInt32(GetUserInput());

                _english.NewCharacter();
                string newchoice = GetUserInput();
                bool newPlayer = NewPlayerSwitch(newchoice);

                Character updatedCharacter = new Character(newName, className, lvl, race, strength, dex, constit, intel, wisd, charis, newPlayer);

                if(updatedCharacter.Name.ToUpper() == character.Name.ToUpper())
                {
                    bool isSuccess = _charRepo.UpdateCharacter(updatedCharacter);
                    if(isSuccess)
                    {
                        _english.CharacterUpdated();
                        _english.PressAnyKey();
                    } else {
                        _english.UpdateFailed();
                        _english.PressAnyKey();
                    }
                    _english.PressAnyKey();
                } else {
                    bool isSuccess = _charRepo.UpdateCharacter(updatedCharacter);
                }
            } else {
                _english.CharacterNotFound();
                _english.PressAnyKey();
                Console.ReadKey();
            }
        }

        private void DeleteCharacter()
        {
            _english.EnterName();
            string name = GetUserInput();

            bool isSuccess = _charRepo.DeleteByCharName(name);

            if(isSuccess)
            {
                _english.DeleteSuccessful();
            } else {
                _english.CharacterNotFound();
            }
            _english.PressAnyKey();
            Console.ReadKey();
        }

        private void MainMenuSwitch(string input)
        {
            switch(input)
            {
                case "1":
                    CreateCharacter();
                    break;
                case "2":
                    ViewCharacter();
                    break;
                case "3":
                    ViewAllCharacters();
                    break;
                case "4":
                    EditCharacter();
                    break;
                case "5":
                    DeleteCharacter();
                    break;
                case "6":
                    isRunning = false;
                    break;
                default:
                    break;
            }
        }

        private ClassType ClassSwitch(string input)
        {
            switch(input)
            {
                case "1":
                return ClassType.barbarian;
            case "2":
                return ClassType.bard;
            case "3":
                return ClassType.cleric;
            case "4":
                return ClassType.druid;
            case "5":
                return ClassType.fighter;
            case "6":
                return ClassType.monk;
            case "7":
                return ClassType.paladin;
            case "8":
                return ClassType.ranger;
            case "9":
                return ClassType.rogue;
            case "10":
                return ClassType.sorcerer;
            case "11":
                return ClassType.warlock;
            case "12":
                return ClassType.wizard;
            default:
                return ClassType.rogue;
            }
        }

        private RaceType RaceSwitch(string input)
        {
            switch(input)
            {
                case "1":
                    return RaceType.dragonborn;
                case "2":
                    return RaceType.dwarf;
                case "3":
                    return RaceType.elf;
                case "4": 
                    return RaceType.gnome;
                case "5":
                    return RaceType.half_elf;
                case "6": 
                    return RaceType.halfling;
                case "7":
                    return RaceType.half_orc;
                case "8":
                    return RaceType.human;
                case "9":
                    return RaceType.tiefling;
                default:
                    return RaceType.human;
            }
        }

        private bool NewPlayerSwitch(string input)
        {
            switch (input)
            {
                case "1":
                    return true;
                case "2": 
                    return false;
                default:
                    return false;
            }
        }
    }
}
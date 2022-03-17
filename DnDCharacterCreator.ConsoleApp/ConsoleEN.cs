using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DnDCharacterCreator.Repository;

namespace DnDCharacterCreator.ConsoleApp
{
    public class ConsoleEN
    {
        public void Welcome()
        {
            Console.WriteLine("Welcome to the DnD Character Creator Console App");
        }

        public void MainMenu()
        {
            Console.WriteLine(
            "Main Menu \n" +
            "1. Create A Character \n" +
            "2. View A Character \n" +
            "3. View All Characters \n" +
            "4. Edit A Character \n" +
            "5. Delete A Character \n" +
            "6. Exit"
            );
        }

        public void EnterName()
        {
            Console.WriteLine("Please Enter A Name.");
        }

        public void EnterClass()
        {
            Console.WriteLine("Please Select a Class \n" +
            "1.Barbarian \n" +
            "2. Bard \n" +
            "3. Cleric \n" + 
            "4. Druid \n" +
            "5. Fighter \n" +
            "6. Monk \n" +
            "7. Paladin \n" +
            "8. Ranger \n" +
            "9. Rogue \n" +
            "10. Sorcerer \n" +
            "11. Warlock \n" +
            "12. Wizard"
            );
        }

        public void EnterLevel()
        {
            Console.WriteLine("Please Enter a Level");
        }

        public void EnterRace()
        {
            Console.WriteLine("Please Select a Race \n" +
            "1. Dragonborn \n" +
            "2. Dwarf \n" +
            "3. Elf \n" +
            "4. Gnome \n" +
            "5. Half Elf \n" +
            "6. Halfling \n" +
            "7. Half Orc \n" +
            "8. Human \n" +
            "9. Tiefling"
            );
        }

        public void EnterStatPoint(int x)
        {
            string[] stats = {"Strength", "Dexterity", "Constitution", "Inteligence", "Wisdom", "Charisma"};
            Console.WriteLine($"Please Enter a Number for {stats[x]}");
        }

        public void PrintCharacter(Character x)
        {
            Console.WriteLine($"{x.Name} the {x.ClassName} \n" +
            $"Level: {x.Lvl} \n" +
            $"Race: {x.Race} \n" +
            $"Strength: {x.Stgth} \n" +
            $"Dexterity: {x.Dex} \n" +
            $"Constitution: {x.Const} \n" +
            $"Inteligence: {x.Int} \n" +
            $"Wisdom: {x.Wisd} \n" +
            $"Charisma: {x.Char} \n"
            
            );
        }

        public void CharacterCreated(string name)
        {
            Console.WriteLine($"{name} successfully added");
        }

        public void CharacterUpdated()
        {
            Console.WriteLine("Character successfully updated");
        }

        public void UpdateFailed()
        {
            Console.WriteLine("Update Failed");
        }

        public void CharacterNotFound()
        {
            Console.WriteLine("Couldn't find the character you were looking for...");
        }

        public void PressAnyKey()
        {
            Console.WriteLine("Press Any Key To Continue...");
        }

        public void NewCharacter()
        {
            Console.WriteLine("Are you new to DnD? \n" +
            "1. Yes \n" +
            "2. No \n"
            );
        }

        public void DeleteSuccessful()
        {
            Console.WriteLine("Character Successfully Deleted");
        }

        
    }
}
using System;
using System.Collections.Generic;
using DnDCharacterCreator.Repository;

namespace DnDCharacterCreator.ConsoleApp
{
    public class Program
    {
        static void Main(string[] args)
        {
            UserInterface ui = new UserInterface(); //instance of UI class
            ui.Run(); //starts the run method for the whole program
        }
    }
}
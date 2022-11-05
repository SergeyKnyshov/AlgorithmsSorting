using AlgorithmsSorting.ConsoleUI;
using System;

namespace AlgorithmsSorting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MenuLogic mainMenu = new MenuLogic(MainMenu.mainMenu);
            mainMenu.Run();
        }
    }
}
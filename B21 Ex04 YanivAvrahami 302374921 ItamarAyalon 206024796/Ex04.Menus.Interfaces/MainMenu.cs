using System;

namespace Ex04.Menus.Interfaces
{
    public class MainMenu
    {
        public MenuItem CurrentMenu { get; set; }
        public bool IsRunning { get; private set; }

        public MainMenu()
        {
        }

        public MainMenu(MenuItem i_StartMenu)
        {
            CurrentMenu = i_StartMenu;
        }

        public void Show()
        {
            IsRunning = true;

            while (IsRunning)
            {
                Console.Clear();
                Console.WriteLine(CurrentMenu.ToString());
                Console.Write("Enter an option: ");

                string optionStr = Console.ReadLine();

                if (int.TryParse(optionStr, out int option) && CurrentMenu.IsValidIndex(option))
                {
                    CurrentMenu.Click(option);
                }
                else
                {
                    Console.WriteLine("No such an option");
                }

                Console.WriteLine("Press enter to continue...");
                Console.ReadLine();
            }

            Console.WriteLine("Bye Bye");
        }

        public void ChangeMenu(MenuItem i_ToMenu)
        {
            CurrentMenu = i_ToMenu;
        }

        public void Back(MenuItem i_CurrentMenu)
        { 
            CurrentMenu = i_CurrentMenu.Parent;
        }

        public void Exit()
        {
            IsRunning = false;
        }
    }
}

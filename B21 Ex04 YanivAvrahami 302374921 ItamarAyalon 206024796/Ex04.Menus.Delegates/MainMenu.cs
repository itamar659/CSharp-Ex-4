using System;

namespace Ex04.Menus.Delegates
{
    public class MainMenu
    {
        public MenuItem CurrentMenuItem { get; set; }
        public bool IsRunning { get; private set; }

        public MainMenu()
        {
        }

        public MainMenu(MenuItem i_StartMenu)
        {
            CurrentMenuItem = i_StartMenu;
        }

        public void Show()
        {
            if (CurrentMenuItem == null)
            {
                throw new NullReferenceException("Need to set the first menu to display.");
            }

            IsRunning = true;

            while (IsRunning)
            {
                Console.Clear();
                Console.WriteLine(CurrentMenuItem.ToString());
                Console.Write("Enter an option: ");

                string optionStr = Console.ReadLine();

                if (int.TryParse(optionStr, out int option) && CurrentMenuItem.IsValidIndex(option))
                {
                    CurrentMenuItem.ClickMe(option);
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

        public void ChangeMenu(MenuItem i_NextMenu)
        {
            CurrentMenuItem = i_NextMenu;
        }

        public void BackMenu()
        {
            CurrentMenuItem = CurrentMenuItem.Parent;
        }

        public void Exit()
        {
            IsRunning = false;
        }
    }
}

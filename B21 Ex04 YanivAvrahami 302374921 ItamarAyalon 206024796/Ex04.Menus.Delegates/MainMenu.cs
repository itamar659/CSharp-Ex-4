using System;

namespace Ex04.Menus.Delegates
{
    public class MainMenu
    {
        public MenuItem CurrentMenuItem { get; set; }
        public bool IsRunning { get; private set; }

        public MainMenu(MenuItem i_StartMenu)
        {
            CurrentMenuItem = i_StartMenu;
        }

        public void Show()
        {
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

        public void Stop()
        {
            IsRunning = false;
        }
    }
}

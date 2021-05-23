using System;

namespace Ex04.Menus.Test
{
    class MethodManager
    {
        static public void CountSpaces()
        {
            Console.WriteLine("Enter a string to count its spaces: ");
            string input = Console.ReadLine();

            if (!string.IsNullOrEmpty(input))
            {
                Console.WriteLine("Number of spaces: {0}.", input.Split(' ').Length - 1);
            }
            else
            {
                Console.WriteLine("0 spaces. The string is empty.");
            }

            pause();
        }

        static public void ShowVersion()
        {
            Console.WriteLine("Version: 21.1.4.8930");
            pause();
        }

        static public void ShowTime()
        {
            Console.WriteLine("The time right now: {0}", DateTime.Now.ToString("HH:mm"));
            pause();
        }

        static public void ShowDate()
        {
            Console.WriteLine("The date today: {0}", DateTime.Today.ToString("dd.MM.yyyy"));
            pause();
        }

        static private void pause()
        {
            Console.WriteLine("Press enter to continue...");
            Console.ReadLine();
        }
    }
}

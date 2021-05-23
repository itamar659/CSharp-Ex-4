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
                Console.WriteLine(string.Format("Number of spaces: {0}.", input.Split(' ').Length - 1));
            }
            else
            {
                Console.WriteLine("0 spaces. The string is empty.");
            }
        }

        static public void ShowVersion()
        {
            Console.WriteLine("ShowVersion: 21.1.4.8930");
        }

        static public void ShowTime()
        {
            Console.WriteLine(DateTime.Now.ToString("HH:mm"));
        }

        static public void ShowDate()
        {
            Console.WriteLine(DateTime.Today.ToString("dd.MM.yyyy"));
        }
    }
}

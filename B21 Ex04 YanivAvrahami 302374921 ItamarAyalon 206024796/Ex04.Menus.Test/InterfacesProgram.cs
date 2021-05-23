using System;
using Ex04.Menus.Interfaces;
using Ex04.Menus.Interfaces.Commands;
using Ex04.Menus.Test.Commands;

namespace Ex04.Menus.Test
{
    public class InterfacesProgram
    {
        public MainMenu InterfacesMainMenu { get; set; }

        public void Run()
        {
            initializeInterfacesMainMenu();
            InterfacesMainMenu.Show();
        }

        void initializeInterfacesMainMenu()
        {
            InterfacesMainMenu = new MainMenu();

            //Menus declarations
            MenuItem mainMenu;
            MenuItem versionAndSpaceMenu;
            MenuItem showDateTimeMenu;

            //Buttons declarations
            MenuItem exitButton;
            MenuItem backButton1;
            MenuItem backButton2;
            MenuItem versionAndSpacesButton;
            MenuItem showDateTimeButton;
            MenuItem showVersionButton;
            MenuItem countSpacesButton;
            MenuItem showTimeButton;
            MenuItem showDateButton;

            //Menus initializations
            mainMenu = new MenuItem("Main Menu");
            versionAndSpaceMenu = new MenuItem("Version And Spaces");
            showDateTimeMenu = new MenuItem("Show Date/Time");

            //Main menu buttons initializations
            exitButton = new MenuItem("Exit", new ExitCommand(InterfacesMainMenu));
            versionAndSpacesButton = new MenuItem("Version And Spaces", new GoToCommand(InterfacesMainMenu, versionAndSpaceMenu));
            showDateTimeButton = new MenuItem("Show Date Time", new GoToCommand(InterfacesMainMenu, showDateTimeMenu));

            //Version and spaces menu buttons initializations
            backButton1 = new MenuItem("Back", new BackCommand(InterfacesMainMenu, versionAndSpaceMenu));
            showVersionButton = new MenuItem("Show Version", new ShowVersionCommand(this));
            countSpacesButton = new MenuItem("Count Spaces", new CountSpacesCommand(this));

            //Show date/time menu buttons initializations
            backButton2 = new MenuItem("Back", new BackCommand(InterfacesMainMenu, showDateTimeMenu));
            showTimeButton = new MenuItem("Show Time", new ShowTimeCommand(this));
            showDateButton = new MenuItem("Show Date", new ShowDateCommand(this));

            //Attaching buttons and menus
            versionAndSpaceMenu.AddMenuItem(backButton1);
            versionAndSpaceMenu.AddMenuItem(showVersionButton);
            versionAndSpaceMenu.AddMenuItem(countSpacesButton);

            showDateTimeMenu.AddMenuItem(backButton2);
            showDateTimeMenu.AddMenuItem(showTimeButton);
            showDateTimeMenu.AddMenuItem(showDateButton);

            mainMenu.AddMenuItem(exitButton);
            mainMenu.AddMenuItem(versionAndSpaceMenu);
            mainMenu.AddMenuItem(showDateTimeMenu);

            InterfacesMainMenu.CurrentMenu = mainMenu;
        }

        public void CountSpaces()
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

        public void ShowVersion()
        {
            Console.WriteLine("Version: 21.1.4.8930");
        }

        public void ShowTime()
        {
            Console.WriteLine(DateTime.Now.ToString("HH:mm"));
        }

        public void ShowDate()
        {
            Console.WriteLine(DateTime.Today.ToString("dd.MM.yyyy"));
        }
    }
}

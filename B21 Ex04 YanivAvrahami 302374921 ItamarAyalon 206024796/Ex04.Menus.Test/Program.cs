using System;
using System.Collections.Generic;
using System.Text;

namespace Ex04.Menus.Test
{
    class Program
    {
        static private Delegates.MainMenu m_MainMenu;

        static void Main()
        {
            initializeDelegateMainMenu();

            m_MainMenu.Show();

            // ICommand changeCommand = new ChangeCommand(countSpacesMenuItem_Click);
        }

        static void initializeDelegateMainMenu()
        {
            m_MainMenu = new Delegates.MainMenu();
            Delegates.SubMenu versionAndSpacesMenu = new Delegates.SubMenu();
            Delegates.SubMenu showdateTimeMenu = new Delegates.SubMenu();
            Delegates.SubMenu openingMenu = new Delegates.SubMenu();
            Delegates.MenuItem showVersionMenuItem = new Delegates.MenuItem();
            Delegates.MenuItem countSpacesMenuItem = new Delegates.MenuItem();
            Delegates.MenuItem showTimeMenuItem = new Delegates.MenuItem();
            Delegates.MenuItem showDateMenuItem = new Delegates.MenuItem();
            Delegates.MenuItem backMenuItem = new Delegates.MenuItem();
            Delegates.MenuItem exitMenuItem = new Delegates.MenuItem();

            //
            // showVersionMenuItem
            //
            showVersionMenuItem.Text = "Show Version";
            showVersionMenuItem.Click += showVersionMenuItem_Click;
            //
            // countSpacesMenuItem
            //
            countSpacesMenuItem.Text = "Count Spaces";
            countSpacesMenuItem.Click += countSpacesMenuItem_Click;
            //
            // showTimeMenuItem
            //
            showTimeMenuItem.Text = "Show Time";
            showTimeMenuItem.Click += showTimeMenuItem_Click;
            //
            // showDateMenuItem
            //
            showDateMenuItem.Text = "Show Date";
            showDateMenuItem.Click += showDate_Click;
            //
            // backMenuItem
            //
            backMenuItem.Text = "Back";
            backMenuItem.Click += m_MainMenu.BackMenu;
            //
            // exitMenuItem
            //
            exitMenuItem.Text = "Exit";
            exitMenuItem.Click += m_MainMenu.Exit;
            //
            // versionAndSpacesMenu
            //
            versionAndSpacesMenu.Text = "Version And Spaces";
            versionAndSpacesMenu.Click += m_MainMenu.ChangeMenu;
            versionAndSpacesMenu.AddMenuItem(backMenuItem);
            versionAndSpacesMenu.AddMenuItem(showVersionMenuItem);
            versionAndSpacesMenu.AddMenuItem(countSpacesMenuItem);
            //
            // showdateTimeMenu
            //
            showdateTimeMenu.Text = "Show Date Time";
            showdateTimeMenu.Click += m_MainMenu.ChangeMenu;
            showdateTimeMenu.AddMenuItem(backMenuItem);
            showdateTimeMenu.AddMenuItem(showTimeMenuItem);
            showdateTimeMenu.AddMenuItem(showDateMenuItem);
            //
            // openingMenu
            //
            openingMenu.Text = "Main Menu";
            openingMenu.AddMenuItem(exitMenuItem);
            openingMenu.AddMenuItem(versionAndSpacesMenu);
            openingMenu.AddMenuItem(showdateTimeMenu);

            // Init the first menu to show
            m_MainMenu.CurrentMenuItem = openingMenu;
        }

        static private void countSpacesMenuItem_Click()
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

        static private void showVersionMenuItem_Click()
        {
            Console.WriteLine("Version: 21.1.4.8930");
        }

        static private void showTimeMenuItem_Click()
        {
            Console.WriteLine(DateTime.Now.ToString("HH:mm"));
        }

        static private void showDate_Click()
        {
            Console.WriteLine(DateTime.Today.ToString("dd.MM.yyyy"));
        }
    }
}

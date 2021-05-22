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

            // ICommand changeCommand = new ChangeCommand(countSpacesBtn_Click);
        }

        static void initializeDelegateMainMenu()
        {
            Delegates.MenuItem backFromVersionAndSpacesBtn = new Delegates.MenuItem();
            Delegates.MenuItem showVersionBtn = new Delegates.MenuItem();
            Delegates.MenuItem countSpacesBtn = new Delegates.MenuItem();
            Delegates.MenuItem versionAndSpacesMenu = new Delegates.MenuItem();
            Delegates.MenuItem backFromShowdateTimeMenuBtn = new Delegates.MenuItem();
            Delegates.MenuItem showTimeBtn = new Delegates.MenuItem();
            Delegates.MenuItem showDateBtn = new Delegates.MenuItem();
            Delegates.MenuItem showdateTimeMenu = new Delegates.MenuItem();
            Delegates.MenuItem exitBtn = new Delegates.MenuItem();
            Delegates.MenuItem openingMenu = new Delegates.MenuItem();

            //
            // backFromVersionAndSpacesBtn
            //
            backFromVersionAndSpacesBtn.Text = "Back";
            backFromVersionAndSpacesBtn.Click += backMenuBtn_Click;
            //
            // showVersionBtn
            //
            showVersionBtn.Text = "Show Version";
            showVersionBtn.Click += showVersionBtn_Click;
            //
            // countSpacesBtn
            //
            countSpacesBtn.Text = "Count Spaces";
            countSpacesBtn.Click += countSpacesBtn_Click;
            //
            // backFromShowdateTimeMenuBtn
            //
            backFromShowdateTimeMenuBtn.Text = "Back";
            backFromShowdateTimeMenuBtn.Click += backMenuBtn_Click;
            //
            // showTimeBtn
            //
            showTimeBtn.Text = "Show Time";
            showTimeBtn.Click += showTimeBtn_Click;
            //
            // showDateBtn
            //
            showDateBtn.Text = "Show Date";
            showDateBtn.Click += showDate_Click;
            //
            // exitBtn
            //
            exitBtn.Text = "Exit";
            exitBtn.Click += exitBtn_Click;
            //
            // versionAndSpacesMenu
            //
            versionAndSpacesMenu.Text = "Version And Spaces";
            versionAndSpacesMenu.Click += changeMenu_Click;
            versionAndSpacesMenu.AddMenuItem(backFromVersionAndSpacesBtn);
            versionAndSpacesMenu.AddMenuItem(showVersionBtn);
            versionAndSpacesMenu.AddMenuItem(countSpacesBtn);
            //
            // showdateTimeMenu
            //
            showdateTimeMenu.Text = "Show Date Time";
            showdateTimeMenu.Click += changeMenu_Click;
            showdateTimeMenu.AddMenuItem(backFromShowdateTimeMenuBtn);
            showdateTimeMenu.AddMenuItem(showTimeBtn);
            showdateTimeMenu.AddMenuItem(showDateBtn);
            //
            // openingMenu
            //
            openingMenu.Text = "Main Menu";
            openingMenu.AddMenuItem(exitBtn);
            openingMenu.AddMenuItem(versionAndSpacesMenu);
            openingMenu.AddMenuItem(showdateTimeMenu);

            m_MainMenu = new Delegates.MainMenu(openingMenu);
        }

        static private void countSpacesBtn_Click(Delegates.MenuItem i_SenderMenuItem)
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

        static private void showVersionBtn_Click(Delegates.MenuItem i_SenderMenuItem)
        {
            Console.WriteLine("Version: 21.1.4.8930");
        }

        static private void changeMenu_Click(Delegates.MenuItem i_SenderMenuItem)
        {
            m_MainMenu.CurrentMenuItem = i_SenderMenuItem;
        }

        static private void showTimeBtn_Click(Delegates.MenuItem i_SenderMenuItem)
        {
            Console.WriteLine(DateTime.Now.ToString("HH:mm"));
        }

        static private void showDate_Click(Delegates.MenuItem i_SenderMenuItem)
        {
            Console.WriteLine(DateTime.Today.ToString("dd.MM.yyyy"));
        }

        static private void backMenuBtn_Click(Delegates.MenuItem i_SenderMenuItem)
        {
            m_MainMenu.CurrentMenuItem = i_SenderMenuItem.Parent.Parent;
        }

        static private void exitBtn_Click(Delegates.MenuItem i_SenderMenuItem)
        {
            m_MainMenu.Stop();
        }
    }
}

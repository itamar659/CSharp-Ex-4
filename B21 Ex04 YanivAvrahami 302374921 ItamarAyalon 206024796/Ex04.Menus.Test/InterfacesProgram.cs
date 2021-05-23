using Ex04.Menus.Interfaces;

namespace Ex04.Menus.Test
{
    public class InterfacesProgram
    {
        private MainMenu m_MainMenu;

        public void Run()
        {
            initializeMainMenu();
            m_MainMenu.Show();
        }

        private void initializeMainMenu()
        {
            m_MainMenu = new MainMenu();
            MenuItem versionAndSpacesMenu = new MenuItem();
            MenuItem showdateTimeMenu = new MenuItem();
            MenuItem openingMenu = new MenuItem();
            MenuItem showVersionMenuItem = new MenuItem();
            MenuItem countSpacesMenuItem = new MenuItem();
            MenuItem showTimeMenuItem = new MenuItem();
            MenuItem showDateMenuItem = new MenuItem();
            MenuItem backMenuItem = new MenuItem();
            MenuItem exitMenuItem = new MenuItem();
            //
            // showVersionMenuItem
            //
            showVersionMenuItem.Text = "Show Version";
            showVersionMenuItem.Command = new ShowVersionCommand();
            //
            // countSpacesMenuItem
            //
            countSpacesMenuItem.Text = "Count Spaces";
            countSpacesMenuItem.Command = new CountSpacesCommand();
            //
            // showTimeMenuItem
            //
            showTimeMenuItem.Text = "Show Time";
            showTimeMenuItem.Command = new ShowTimeCommand();
            //
            // showDateMenuItem
            //
            showDateMenuItem.Text = "Show Date";
            showDateMenuItem.Command = new ShowDateCommand();
            //
            // backMenuItem
            //
            backMenuItem.Text = "Back";
            backMenuItem.Command = new BackCommand(m_MainMenu);
            //
            // exitMenuItem
            //
            exitMenuItem.Text = "Exit";
            exitMenuItem.Command = new ExitCommand(m_MainMenu);
            //
            // versionAndSpacesMenu
            //
            versionAndSpacesMenu.Text = "Version And Spaces";
            versionAndSpacesMenu.Command = new GoToCommand(m_MainMenu, versionAndSpacesMenu);
            versionAndSpacesMenu.AddMenuItem(backMenuItem);
            versionAndSpacesMenu.AddMenuItem(showVersionMenuItem);
            versionAndSpacesMenu.AddMenuItem(countSpacesMenuItem);
            //
            // showdateTimeMenu
            //
            showdateTimeMenu.Text = "Show Date/Time";
            showdateTimeMenu.Command = new GoToCommand(m_MainMenu, showdateTimeMenu);
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
            m_MainMenu.CurrentMenu = openingMenu;
        }
    }
}

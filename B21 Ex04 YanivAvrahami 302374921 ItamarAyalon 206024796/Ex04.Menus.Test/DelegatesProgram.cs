using Ex04.Menus.Delegates;

namespace Ex04.Menus.Test
{
    class DelegatesProgram
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
            SubMenu versionAndSpacesMenu = new SubMenu();
            SubMenu showdateTimeMenu = new SubMenu();
            SubMenu openingMenu = new SubMenu();
            MenuItem showVersionMenuItem = new MenuItem();
            MenuItem countSpacesMenuItem = new MenuItem();
            MenuItem showTimeMenuItem = new MenuItem();
            MenuItem showDateMenuItem = new MenuItem();
            MenuItem backMenuItem = new MenuItem();
            MenuItem exitMenuItem = new MenuItem();
            //
            // showVersionMenuItem
            //
            showVersionMenuItem.Text = "Show ShowVersion";
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
            showDateMenuItem.Click += showDateMenuItem_Click;
            //
            // backMenuItem
            //
            backMenuItem.Text = "Back";
            backMenuItem.Click += backMenuItem_Click;
            //
            // exitMenuItem
            //
            exitMenuItem.Text = "Exit";
            exitMenuItem.Click += exitMenuItem_Click;
            //
            // versionAndSpacesMenu
            //
            versionAndSpacesMenu.Text = "Show Version And Spaces";
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

        private void countSpacesMenuItem_Click()
        {
            MethodManager.CountSpaces();
        }

        private void showVersionMenuItem_Click()
        {
            MethodManager.ShowVersion();
        }

        private void showTimeMenuItem_Click()
        {
            MethodManager.ShowTime();
        }

        private void showDateMenuItem_Click()
        {
            MethodManager.ShowDate();
        }

        private void backMenuItem_Click()
        {
            m_MainMenu.BackMenu();
        }

        private void exitMenuItem_Click()
        {
            m_MainMenu.Exit();
        }
    }
}

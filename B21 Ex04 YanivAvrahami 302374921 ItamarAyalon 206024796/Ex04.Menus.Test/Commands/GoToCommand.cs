namespace Ex04.Menus.Interfaces.Commands
{
    class GoToCommand : ICommand
    {
        private MainMenu m_MainMenu;
        private MenuItem m_MenuItem;

        public GoToCommand(MainMenu i_MainMenu, MenuItem i_ToMenu)
        {
            m_MainMenu = i_MainMenu;
            m_MenuItem = i_ToMenu;
        }

        public void Execute()
        {
            m_MainMenu.ChangeMenu(m_MenuItem);
        }
    }
}

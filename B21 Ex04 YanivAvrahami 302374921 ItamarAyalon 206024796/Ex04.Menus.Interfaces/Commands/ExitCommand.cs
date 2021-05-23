namespace Ex04.Menus.Interfaces.Commands
{
    public class ExitCommand : ICommand
    {
        private MainMenu m_MainMenu;

        public ExitCommand(MainMenu i_MainMenu)
        {
            m_MainMenu = i_MainMenu;
        }

        public void Execute()
        {
            m_MainMenu.Exit();
        }
    }
}

namespace Ex04.Menus.Interfaces
{
    public class ExitCommand : ICommand
    {
        private MainMenu m_MainMenu;

        public ExitCommand(MainMenu i_MainMenu)
        {
            m_MainMenu = i_MainMenu;
        }

        void ICommand.Execute()
        {
            m_MainMenu.Exit();
        }
    }
}

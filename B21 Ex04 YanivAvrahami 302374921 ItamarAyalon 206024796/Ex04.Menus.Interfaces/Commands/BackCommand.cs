namespace Ex04.Menus.Interfaces.Commands
{
    public class BackCommand : ICommand
    {
        private MainMenu m_MainMenu; 

        public BackCommand(MainMenu i_MainMenu)
        {
            m_MainMenu = i_MainMenu;
        }

        public void Execute()
        {
            m_MainMenu.Back();
        }
    }
}
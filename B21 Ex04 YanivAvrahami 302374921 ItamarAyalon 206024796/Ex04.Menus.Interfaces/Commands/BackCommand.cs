namespace Ex04.Menus.Interfaces
{
    public class BackCommand : ICommand
    {
        private MainMenu m_MainMenu; 

        public BackCommand(MainMenu i_MainMenu)
        {
            m_MainMenu = i_MainMenu;
        }

        void ICommand.Execute()
        {
            m_MainMenu.Back();
        }
    }
}
namespace Ex04.Menus.Interfaces.Commands
{
    public class BackCommand : ICommand
    {
        public MainMenu MainMenu { get; }
        public MenuItem MenuItem { get; }

        public BackCommand(MainMenu i_MainMenu, MenuItem i_CurrentMenu)
        {
            MainMenu = i_MainMenu;
            MenuItem = i_CurrentMenu;
        }

        public void Execute()
        {
            MainMenu.Back(MenuItem);
        }
    }
}
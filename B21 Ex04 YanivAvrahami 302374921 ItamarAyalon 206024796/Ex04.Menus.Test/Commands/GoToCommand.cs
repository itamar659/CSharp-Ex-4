namespace Ex04.Menus.Interfaces.Commands
{
    class GoToCommand : ICommand
    {
        public MainMenu MainMenu { get; }
        public MenuItem MenuItem { get; }

        public GoToCommand(MainMenu i_MainMenu, MenuItem i_ToMenu)
        {
            MainMenu = i_MainMenu;
            MenuItem = i_ToMenu;
        }

        public void Execute()
        {
            MainMenu.Back(MenuItem);
        }
    }
}

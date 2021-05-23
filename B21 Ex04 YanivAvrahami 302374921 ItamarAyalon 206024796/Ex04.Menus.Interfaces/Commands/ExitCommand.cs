namespace Ex04.Menus.Interfaces.Commands
{
    public class ExitCommand : ICommand
    {
        public MainMenu MainMenu { get; }

        public ExitCommand(MainMenu i_MainMenu)
        {
            MainMenu = i_MainMenu;
        }

        public void Execute()
        {
            MainMenu.Exit();
        }
    }
}

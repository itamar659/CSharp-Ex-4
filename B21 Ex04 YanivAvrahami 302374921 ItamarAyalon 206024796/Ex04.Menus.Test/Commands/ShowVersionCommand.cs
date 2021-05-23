using Ex04.Menus.Interfaces;

namespace Ex04.Menus.Test.Commands
{
    class ShowVersionCommand : ICommand
    {
        public void Execute()
        {
            MethodManager.ShowVersion();
        }
    }
}
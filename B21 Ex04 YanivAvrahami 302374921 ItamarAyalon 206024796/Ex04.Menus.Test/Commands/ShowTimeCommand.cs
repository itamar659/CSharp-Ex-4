using Ex04.Menus.Interfaces;

namespace Ex04.Menus.Test.Commands
{
    class ShowTimeCommand : ICommand
    {
        public void Execute()
        {
            MethodManager.ShowTime();
        }
    }
}
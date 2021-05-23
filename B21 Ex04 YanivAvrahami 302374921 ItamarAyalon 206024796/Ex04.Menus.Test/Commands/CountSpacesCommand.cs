using Ex04.Menus.Interfaces;

namespace Ex04.Menus.Test.Commands
{
    class CountSpacesCommand : ICommand
    {
        public void Execute()
        {
            MethodManager.CountSpaces();
        }
    }
}
using Ex04.Menus.Interfaces;

namespace Ex04.Menus.Test.Commands
{
    class ShowDateCommand : ICommand
    {
        public void Execute()
        {
            MethodManager.ShowDate();
        }
    }
}
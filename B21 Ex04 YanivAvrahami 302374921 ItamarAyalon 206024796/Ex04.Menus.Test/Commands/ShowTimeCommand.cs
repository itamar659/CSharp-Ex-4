using Ex04.Menus.Interfaces;

namespace Ex04.Menus.Test
{
    class ShowTimeCommand : ICommand
    {
        void ICommand.Execute()
        {
            MethodManager.ShowTime();
        }
    }
}
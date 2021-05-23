using Ex04.Menus.Interfaces;

namespace Ex04.Menus.Test
{
    class ShowVersionCommand : ICommand
    {
        void ICommand.Execute()
        {
            MethodManager.ShowVersion();
        }
    }
}
using Ex04.Menus.Interfaces;

namespace Ex04.Menus.Test
{
    class CountSpacesCommand : ICommand
    {
        void ICommand.Execute()
        {
            MethodManager.CountSpaces();
        }
    }
}
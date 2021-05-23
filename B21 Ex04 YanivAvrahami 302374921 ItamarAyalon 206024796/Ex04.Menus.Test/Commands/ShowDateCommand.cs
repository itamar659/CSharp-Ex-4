using Ex04.Menus.Interfaces;

namespace Ex04.Menus.Test
{
    class ShowDateCommand : ICommand
    {
        void ICommand.Execute()
        {
            MethodManager.ShowDate();
        }
    }
}
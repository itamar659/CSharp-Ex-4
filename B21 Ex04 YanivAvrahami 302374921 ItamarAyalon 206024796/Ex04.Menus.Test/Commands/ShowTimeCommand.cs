using Ex04.Menus.Interfaces;

namespace Ex04.Menus.Test.Commands
{
    class ShowTimeCommand : ICommand
    {
        public InterfacesProgram InterfacesProgram { get; }

        public ShowTimeCommand(InterfacesProgram i_InterfacesProgram)
        {
            InterfacesProgram = i_InterfacesProgram;
        }

        public void Execute()
        {
            InterfacesProgram.ShowTime();
        }
    }
}
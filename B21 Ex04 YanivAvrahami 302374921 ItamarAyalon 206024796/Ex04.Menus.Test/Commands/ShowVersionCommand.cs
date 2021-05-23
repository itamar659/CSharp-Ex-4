using Ex04.Menus.Interfaces;

namespace Ex04.Menus.Test.Commands
{
    class ShowVersionCommand : ICommand
    {
        public InterfacesProgram InterfacesProgram { get; }

        public ShowVersionCommand(InterfacesProgram i_InterfacesProgram)
        {
            InterfacesProgram = i_InterfacesProgram;
        }

        public void Execute()
        {
            InterfacesProgram.ShowVersion();
        }
    }
}
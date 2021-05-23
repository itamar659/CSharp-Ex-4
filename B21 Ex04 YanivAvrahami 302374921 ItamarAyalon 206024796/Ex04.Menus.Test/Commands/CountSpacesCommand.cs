using Ex04.Menus.Interfaces;

namespace Ex04.Menus.Test.Commands
{
    class CountSpacesCommand : ICommand
    {
        public InterfacesProgram InterfacesProgram { get; }

        public CountSpacesCommand(InterfacesProgram i_InterfacesProgram)
        {
            InterfacesProgram = i_InterfacesProgram;
        }

        public void Execute()
        {
            InterfacesProgram.CountSpaces();
        }
    }
}
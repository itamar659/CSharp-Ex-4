using Ex04.Menus.Interfaces;

namespace Ex04.Menus.Test.Commands
{
    class ShowDateCommand : ICommand
    {
        public InterfacesProgram InterfacesProgram { get; }

        public ShowDateCommand(InterfacesProgram i_InterfacesProgram)
        {
            InterfacesProgram = i_InterfacesProgram;
        }

        public void Execute()
        {
            InterfacesProgram.ShowDate();
        }
    }
}
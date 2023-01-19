namespace Command
{
    public class RemoteControl
    {
        private Command[] OnCommands;
        private Command[] OffCommands;
        private Command lastCommand;

        public RemoteControl()
        {
            OnCommands = new Command[3];
            OffCommands = new Command[3];
            for (int i = 0; i < 2; i++)
            {
                OnCommands[i] = new NoCommand();
                OffCommands[i] = new NoCommand();
            }
        }

        public void SetButton(int position, Command onCommand, Command offCommand)
        {
            OnCommands[position] = onCommand;
            OffCommands[position] = offCommand;
        }

        public void PressOnButton(int position) { OnCommands[position].Execute(); lastCommand = OnCommands[position]; }

        public void PressOffButton(int position) { OffCommands[position].Execute(); lastCommand = OffCommands[position]; }

        public void Undo() { this.lastCommand.Undo(); }
    }
}
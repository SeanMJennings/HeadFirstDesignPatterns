// See https://aka.ms/new-console-template for more information
using Command;

var remoteControl = new RemoteControl();

remoteControl.SetButton(0, new GarageDoorOpenCommand(new GarageDoor()), new GarageDoorCloseCommand(new GarageDoor()));
remoteControl.SetButton(1, new LightOnConmnand(new Light()), new LightOffCommand(new Light()));
remoteControl.SetButton(2, new DiscoOnCommand(), new DiscoOffCommand());

remoteControl.PressOnButton(0);
remoteControl.PressOffButton(0);

remoteControl.PressOnButton(1);
remoteControl.PressOffButton(1);

remoteControl.PressOnButton(2);
remoteControl.PressOffButton(2);

remoteControl.PressOnButton(2);
remoteControl.Undo();
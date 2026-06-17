using NUnit.Framework;
using System.Collections.Generic;
using UnityEngine;

public class MacroCommand : ICommand
{
    private List<ICommand> commands = new List<ICommand>();


    public void AddCommand(ICommand command)
    {
        commands.Add(command);
    }

    public void Execute()
    {
        foreach(ICommand command in commands)
        {
            command.Execute();
        }
    }

    public void Undo()
    {
        for (int i = commands.Count -1; i >= 0; i--)
        {
            commands[i].Undo();
        }
    }
}

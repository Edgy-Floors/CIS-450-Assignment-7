using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenDoor : Command
{
    Openable _o;
    Stack commandHistory;

    public OpenDoor(Openable o)
    {
        _o = GameObject.Find("Door").GetComponent<Openable>();
        commandHistory = new Stack();
    }

    public void execute()
    {
        commandHistory.Push(1);
        _o.open();
    }

    public void undo()
    {
        if(commandHistory.Count != 0)
        {
            _o.close();
            commandHistory.Pop();
        }
    }
}

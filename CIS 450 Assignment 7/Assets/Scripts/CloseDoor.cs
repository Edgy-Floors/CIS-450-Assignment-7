/* 
 *  EJ Flores
 *  CloseDoor.cs
 *  Assignment 7
 *  This script is the command to close a door.
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloseDoor : Command
{
    Openable _o;
    Stack commandHistory;

    public CloseDoor(Openable o)
    {
        _o = GameObject.Find("Door").GetComponent<Openable>();
        commandHistory = new Stack();
    }

    public void execute()
    {
        commandHistory.Push(1);
        _o.close();
    }

    public void undo()
    {
        if (commandHistory.Count != 0)
        {
            _o.open();
            commandHistory.Pop();
        }
    }
}

/* 
 *  EJ Flores
 *  OpenHatch.cs
 *  Assignment 7
 *  This script is the command to open a hatch.
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenHatch : Command
{
    Openable _o;
    Stack commandHistory;

    public OpenHatch(Openable o)
    {
        _o = GameObject.Find("Hatch").GetComponent<Openable>();
        commandHistory = new Stack();
    }

    public void execute()
    {
        commandHistory.Push(1);
        _o.open();
    }

    public void undo()
    {
        if (commandHistory.Count != 0)
        {
            _o.close();
            commandHistory.Pop();
        }
    }
}

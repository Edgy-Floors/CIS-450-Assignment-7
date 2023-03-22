/* 
 *  EJ Flores
 *  CloseHatch.cs
 *  Assignment 7
 *  This script is the command to close a hatch.
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloseHatch : Command
{
    Openable _o;
    Stack commandHsitory;

    public CloseHatch(Openable o)
    {
        _o = GameObject.Find("Hatch").GetComponent<Openable>();
        commandHsitory = new Stack();
    }

    public void execute()
    {
        commandHsitory.Push(1);
        _o.close();
    }

    public void undo()
    {
        if (commandHsitory.Count != 0)
        {
            _o.open();
            commandHsitory.Pop();
        }
    }
}

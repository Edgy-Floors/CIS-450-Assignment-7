/* 
 *  EJ Flores
 *  Command.cs
 *  Assignment 7
 *  This script is the command interface.
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface Command
{
    public void execute();
    public void undo();
}

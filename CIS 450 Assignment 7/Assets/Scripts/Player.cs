/* 
 *  EJ Flores
 *  Player.cs
 *  Assignment 7
 *  This script handles the various opening and closing of doors via commands, basically acting as the Invoker.
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float speed = 5.0f;
    public Stack<Command> commandHistory;
    public Door d;
    public Hatch h;
    private Command dOpen;
    private Command dClose;
    private Command hOpen;
    private Command hClose;

    private void Awake()
    {
        dOpen = new OpenDoor(d);
        dClose = new CloseDoor(d);
        hOpen = new OpenHatch(h);
        hClose = new CloseHatch(h);

        commandHistory = new Stack<Command>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(Vector3.forward * Time.deltaTime * speed);
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(-1 * Vector3.forward * Time.deltaTime * speed);
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(Vector3.left * Time.deltaTime * speed);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(Vector3.right * Time.deltaTime * speed);
        }
        if (Input.GetKeyDown(KeyCode.P))
        {
            if(commandHistory.Count != 0)
            {
                Command lastCommand = commandHistory.Pop();
                lastCommand.undo();
            }
        }
        if (Input.GetKeyDown(KeyCode.J))
        {
            dOpen.execute();
            commandHistory.Push(dOpen);
        }
        if (Input.GetKeyDown(KeyCode.K))
        {
            dClose.execute();
            commandHistory.Push(dClose);
        }
        if (Input.GetKeyDown(KeyCode.L))
        {
            hOpen.execute();
            commandHistory.Push(hOpen);
        }
        if (Input.GetKeyDown(KeyCode.M))
        {
            hClose.execute();
            commandHistory.Push(hClose);
        }
    }
}

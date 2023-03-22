/* 
 *  EJ Flores
 *  Door.cs
 *  Assignment 7
 *  This script is the concrete class Door for Openable.
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour, Openable
{
    public bool isOpen = false;

    public void close()
    {
        if (isOpen)
        {
            isOpen = !isOpen;
            gameObject.SetActive(true);
        }
    }

    public void open()
    {
        if (!isOpen)
        {
            isOpen = !isOpen;
            gameObject.SetActive(false);
        }
    }
}

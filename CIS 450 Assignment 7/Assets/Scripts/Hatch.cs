using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hatch : MonoBehaviour, Openable
{
    public bool isOpen = false;

    public void close()
    {
        if (isOpen)
        {
            gameObject.SetActive(true);
            isOpen = !isOpen;
        }
    }

    public void open()
    {
        if (!isOpen)
        {
            gameObject.SetActive(false);
            isOpen = !isOpen;
        }
    }
}

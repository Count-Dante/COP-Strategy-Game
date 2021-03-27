using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BadEventController : MonoBehaviour
{
    public bool easy;
    public bool medium;
    public bool hard;
    public bool extreme;

    public double badEvenetMultiplier()
    {
        if (easy)
        {
            return 1.0;
        }
        else if (medium)
        {
            return 1.5;
        }
        else if (hard)
        {
            return 2.0;
        }
        else
        {
            return 3.0;
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BadRNG : MonoBehaviour
{

    // Referencing the 'PostRNG' object within the scene
    public GameObject PostRNG;
    public static bool deadGame = false;

    // Function that determines which random-bad event will occur.
    public void whichEvent()
    {

        // Variable to store the calculated current event and defense value.
        int curEvent = 0;
        float defense = DefenseBar.defensePoint;

        // Sets the PostRNG object active to allow for a pop-up to appear.
        PostRNG.SetActive(true);

        // Calculates a value between 1-3 inclusive to serve as the random event.
        int which = UnityEngine.Random.Range(1, 4);

        switch (which)
        {
            case 1:
                curEvent = 1;
                break;
            case 2:
                curEvent = 2;
                break;
            case 3:
                curEvent = 3;
                break;
        }

        // Sets the object / image associated with the current event to active and sets the
        PostRNG.transform.GetChild(curEvent).gameObject.SetActive(true);

    }

    public static bool isGameDead()
    {
      return deadGame;
    }
}

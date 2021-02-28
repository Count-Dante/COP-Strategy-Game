using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BadRNG : MonoBehaviour
{

    public GameObject PostRNG;

    public void whichEvent()
    {
    
        int wood = Resources.getWood();
        int gold = Resources.getGold();
        int food = Resources.getFood();

        int curEvent = 0;
        //   int defense = wood;
        int defense = wood + gold + food;

        PostRNG.SetActive(true);

        int which = UnityEngine.Random.Range(1, 3);

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

        if (curEvent == 1 && defense - 15 >= 0)
            defense -= 15;
        

        else if (curEvent == 2 && defense - 10 >= 0)
            defense -= 10;

        else if (curEvent == 3 && defense - 5 >= 0)
            defense -= 5;
        

        else
            curEvent = 4;

        //PostRNG.SetActive(true);
        PostRNG.transform.GetChild(curEvent).gameObject.SetActive(true);

        Debug.Log("Current event is " + curEvent);
        Debug.Log("defense is " + defense);
        Debug.Log("expansion is ");


        // reutrn cur

    }   
}

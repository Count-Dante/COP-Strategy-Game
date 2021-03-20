using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TorandoEvent : MonoBehaviour
{
    public static float defenseFillPercentage = 0;
    public static int updateResource = 0;

    public GameObject PostRNG;

    public void resourceRemoved()
    {
        defenseFillPercentage = (DefenseBar.defensePoint / DefenseController.defenseMaxValue) * 100;

        if (defenseFillPercentage <= 25.0)
        {
            updateResource = resourceRemovalCalculator(25);
        }
        else if (defenseFillPercentage <= 50.0)
        {
            updateResource = resourceRemovalCalculator(50);
        }
        else if (defenseFillPercentage <= 75.0)
        {
            updateResource = resourceRemovalCalculator(75);
        }
        else
        {
            updateResource = resourceRemovalCalculator(100);
        }

        Resources.setWood(updateResource);
    }

    public static int resourceRemovalCalculator(int percent)
    {
        int woodResourceVal = Resources.getWood();
        int amountKept = (woodResourceVal * percent) / 100;

        return amountKept;
    }

    public void checkIfPlayerLose()
    {
        float defense = DefenseBar.defensePoint - 20;

        if (defense <= 0)
        {
            DefenseBar.defensePoint = 0;
            BadRNG.deadGame = true;

            PostRNG.transform.GetChild(4).gameObject.SetActive(true);
        }

        else
        {
            DefenseBar.defensePoint = defense;
            PostRNG.gameObject.SetActive(false);
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

// Class is used for other UI features to connect to and demonstrate expansion points
public class ExpansionController : MonoBehaviour
{
    public const int easyExpansion = 50;
    public const int mediumExpansion = 60;
    public const int hardExpansion = 70;
    public const int extremeExpansion = 80;

    public bool easy;
    public bool medium;
    public bool hard;
    public bool extreme;

    public static float wood = 0;
    public static float gold = 0;
    public static float food = 0;

    public Button expansion;

    void Start()
    {
      expansion.gameObject.SetActive(false);
    }

    public void removeResources()
    {
      Resources.setWood((int)(Resources.getWood() - wood));
      Resources.setGold((int)(Resources.getGold() - gold));
      Resources.setFood((int)(Resources.getFood() - food));
    }

    public void expandByLevel()
    {
      if (easy && ExpansionBar.getCurrentExpansionPoint() >= easyExpansion)
        {
          expansion.gameObject.SetActive(true);
        }

      if (medium && ExpansionBar.getCurrentExpansionPoint() >= mediumExpansion)
        {
          expansion.gameObject.SetActive(true);
        }

      if (hard && ExpansionBar.getCurrentExpansionPoint() >= hardExpansion)
        {
          expansion.gameObject.SetActive(true);
        }

      if (extreme && ExpansionBar.getCurrentExpansionPoint() >= extremeExpansion)
        {
          expansion.gameObject.SetActive(true);
        }
    }

    public void expandNewSettlement()
    {
      SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void setActiveExpansionButton()
    {
      expansion.gameObject.SetActive(true);
    }

}

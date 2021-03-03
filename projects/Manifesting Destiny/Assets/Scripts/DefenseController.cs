using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DefenseController : MonoBehaviour
{
  public static float wood = 0;
  public static float gold = 0;
  public static float food = 0;

  public static float defenseMaxValue = 100f;
  public static float defensePoints = 0;

  public void removeResources()
  {
    Resources.setWood((int)(Resources.getWood() - wood));
    Resources.setGold((int)(Resources.getGold() - gold));
    Resources.setFood((int)(Resources.getFood() - food));
  }
}

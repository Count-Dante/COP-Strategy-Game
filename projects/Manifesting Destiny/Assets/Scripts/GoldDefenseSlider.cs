using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GoldDefenseSlider : Sliders
{
  void Update()
  {
    inventory = Resources.getGold();
    resourceSlider.maxValue = inventory;

    DefenseController.gold = resourceAmount;
  }

  public void setActiveSlider()
  {
    ResourceInventory.goldDefSliderActive = true;
  }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FoodDefenseSlider : Sliders
{
  void Update()
  {
    inventory = Resources.getFood();
    resourceSlider.maxValue = inventory;

    DefenseController.food = resourceAmount;
  }

  public void setActiveSlider()
  {
    ResourceInventory.foodDefSliderActive = true;
  }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WoodDefenseSlider : Sliders
{
  void Update()
  {
    inventory = Resources.getWood();
    resourceSlider.maxValue = inventory;

    DefenseController.wood = resourceAmount;
  }
}

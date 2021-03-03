using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FoodSlider : Sliders
{
    void Update()
    {
      inventory = Resources.getFood();
      resourceSlider.maxValue = inventory;

      ExpansionController.food = resourceAmount;
    }
}

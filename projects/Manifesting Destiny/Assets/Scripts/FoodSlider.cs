using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FoodSlider : ExpansionSlider
{
    void Update()
    {
      inventory = Resources.getFood();
      resourceSlider.maxValue = inventory;

      ExpansionController.food = resourceAmount;
    }
}

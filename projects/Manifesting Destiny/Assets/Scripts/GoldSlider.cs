using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GoldSlider : Sliders
{
    void Update()
    {
      inventory = Resources.getGold();
      resourceSlider.maxValue = inventory;

      ExpansionController.gold = resourceAmount;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.UI;
using TMPro;

public class ResourceInventory : MonoBehaviour
{
    public static float wood;
    public static float food;
    public static float gold;

    private static int startWood;
    private static int startFood;
    private static int startGold;

    public Text woodtext;

    public Slider woodExpansion;
    public Slider woodDefense;

    public Slider goldExpansion;
    public Slider goldDefense;

    public Slider foodExpansion;
    public Slider foodDefense;

    public static bool woodExpSliderActive = false;
    public static bool woodDefSliderActive = false;

    public static bool goldExpSliderActive = false;
    public static bool goldDefSliderActive = false;

    public static bool foodExpSliderActive = false;
    public static bool foodDefSliderActive = false;

    public void getInventory()
    {
      startWood = Resources.getWood();
      startFood = Resources.getFood();
      startGold = Resources.getGold();
    }

    private void updateSlider()
    {
      if ((woodExpansion.value + woodDefense.value > startWood))
      {
        if (woodExpSliderActive)
        {
          woodExpSliderActive = false;
          float change = woodExpansion.value + woodDefense.value - startWood;
          woodDefense.value = woodDefense.value - change;
        }

        if (woodDefSliderActive)
        {
          woodDefSliderActive = false;
          float change = woodExpansion.value + woodDefense.value - startWood;
          woodExpansion.value = woodExpansion.value - change;
        }
      }

      if (goldExpansion.value + goldDefense.value > startGold)
      {
        if (goldExpSliderActive)
        {
          goldExpSliderActive = false;
          float change = goldExpansion.value + goldDefense.value - startGold;
          goldDefense.value = goldDefense.value - change;
        }

        if (goldDefSliderActive)
        {
          goldDefSliderActive = false;
          float change = goldExpansion.value + goldDefense.value - startGold;
          goldExpansion.value = goldExpansion.value - change;
        }
      }

      if (foodExpansion.value + foodDefense.value > startFood)
      {
        if (foodExpSliderActive)
        {
          foodExpSliderActive = false;
          float change = foodExpansion.value + foodDefense.value - startFood;
          foodDefense.value = foodDefense.value - change;
        }

        if (foodDefSliderActive)
        {
          foodDefSliderActive = false;
          float change = foodExpansion.value + foodDefense.value - startFood;
          foodExpansion.value = foodExpansion.value - change;
        }
      }
    }

    public void resetSlider()
    {
      ExpansionBar.expansionPoint = ExpansionBar.expansionPoint + ExpansionBar.getCurrentExpansionPoint();
      DefenseBar.defensePoint = DefenseBar.defensePoint + DefenseBar.getCurrentDefensePoint();
      
      woodExpansion.value = 0;
      woodDefense.value = 0;

      goldExpansion.value = 0;
      goldDefense.value = 0;

      foodExpansion.value = 0;
      foodDefense.value = 0;
    }

    void Update()
    {
      woodtext.text = Convert.ToString(wood);
      updateSlider();
      reevaluateResource();
    }

    private void reevaluateResource()
    {
      wood = startWood - ExpansionController.wood - DefenseController.wood;
      food = startFood - ExpansionController.food - DefenseController.food;
      gold = startGold - ExpansionController.gold - DefenseController.gold;
    }
}

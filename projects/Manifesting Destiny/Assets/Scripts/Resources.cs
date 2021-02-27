using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Resources : MonoBehaviour
{
      public static int totalFood = 0;
      public static int totalGold = 0;
      public static int totalWood = 0;

      public static int getFood()
      {
            return totalFood;
      }

      public static void setFood(int amount)
      {
            totalFood = amount;
      }

      public static int getGold()
      {
            return totalGold;
      }

      public static void setGold(int amount)
      {
            totalGold = amount;
      }

      public static int getWood()
      {
            return totalWood;
      }

      public static void setWood(int amount)
      {
            totalWood = amount;
      }
}

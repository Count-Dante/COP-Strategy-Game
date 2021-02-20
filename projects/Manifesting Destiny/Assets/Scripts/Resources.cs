using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Resources : MonoBehaviour
{

      private static int gold = 0;
      private static int wood = 0;
      private static int food = 0;

      public static int getGold()
      {
            return gold;
      }

      public static void setGold(int amount)
      {
            gold = amount;
      }

      public static int getWood()
      {
            return wood;
      }

      public static void setWood(int amount)
      {
            wood = amount;
      }

      public static int getFood()
      {
            return food;
      }

      public static void setFood(int amount)
      {
            food = amount;
      }

      // Get random number from 1 - 100 (inclusive).
      public static int randomNumberGenerator()
      {
            return UnityEngine.Random.Range(1,100);
      }

      void Update()
      {
            Debug.Log(wood);
      }



}

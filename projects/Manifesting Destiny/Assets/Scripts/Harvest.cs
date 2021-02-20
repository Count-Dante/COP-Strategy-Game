using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Harvest : MonoBehaviour
{
      // Gather 1 Resource: 10%
      // Gather 2 Resources: 20%
      // Gather 3 Resources: 40%
      // Gather 4 Resources: 20%
      // Gather 5 Resources: 10%
      public void gatherGold()
      {
            int goldAmount = Resources.getGold();
            int randomNumber = Resources.randomNumberGenerator();

            if (randomNumber <= 10)
            {
                  Resources.setGold(goldAmount + 1);
            }

            else if (randomNumber <= 30)
            {
                  Resources.setGold(goldAmount + 2);
            }

            else if (randomNumber <= 70)
            {
                  Resources.setGold(goldAmount + 3);
            }

            else if (randomNumber <= 90)
            {
                  Resources.setGold(goldAmount + 4);
            }

            else
            {
                  Resources.setGold(goldAmount + 5);
            }
      }

      public void gatherWood()
      {
            int woodAmount = Resources.getWood();
            int randomNumber = Resources.randomNumberGenerator();

            if (randomNumber <= 10)
            {
                  Resources.setWood(woodAmount + 1);
            }

            else if (randomNumber <= 30)
            {
                  Resources.setWood(woodAmount + 2);
            }

            else if (randomNumber <= 70)
            {
                  Resources.setWood(woodAmount + 3);
            }

            else if (randomNumber <= 90)
            {
                  Resources.setWood(woodAmount + 4);
            }

            else
            {
                  Resources.setWood(woodAmount + 5);
            }
      }

      public void gatherFood()
      {
            int foodAmount = Resources.getFood();
            int randomNumber = Resources.randomNumberGenerator();

            if (randomNumber <= 10)
            {
                  Resources.setFood(foodAmount + 1);
            }

            else if (randomNumber <= 30)
            {
                  Resources.setFood(foodAmount + 2);
            }

            else if (randomNumber <= 70)
            {
                  Resources.setFood(foodAmount + 3);
            }

            else if (randomNumber <= 90)
            {
                  Resources.setFood(foodAmount + 4);
            }

            else
            {
                  Resources.setFood(foodAmount + 5);
            }
      }

      void Update()
      {
            Debug.Log(Resources.getWood());
      }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Food : MonoBehaviour
{
      public static int numberOfClicks = 5;
      public static bool timerEnabled;

      // Harvest methods must be seperate for each resource for game balancing.
      // Gather 1 Food: 10%
      // Gather 2 Food: 20%
      // Gather 3 Food: 40%
      // Gather 4 Food: 20%
      // Gather 5 Food: 10%
      public void harvestFood()
      {
            // Resource can still be harvested!
            if (numberOfClicks > 0 && timerEnabled == true)
            {
                  // Used to determine "luck" of how many resources are gathered.
                  int randomNumber = RNG.randomNumberGenerator();

                  if (randomNumber <= 10)
                  {
                        Resources.setFood(Resources.getFood() + 1);
                  }

                  else if (randomNumber <= 30)
                  {
                        Resources.setFood(Resources.getFood() + 2);
                  }

                  else if (randomNumber <= 70)
                  {
                        Resources.setFood(Resources.getFood() + 3);
                  }

                  else if (randomNumber <= 90)
                  {
                        Resources.setFood(Resources.getFood() + 4);
                  }

                  else
                  {
                        Resources.setFood(Resources.getFood() + 5);
                  }

                  // Decrement the number of clicks remaining for this tile.
                  numberOfClicks -= 1;
            }
      }

      void Update()
      {
            timerEnabled = Timer.getTimerStatus();
      }

}

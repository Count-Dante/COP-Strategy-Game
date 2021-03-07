using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wood : MonoBehaviour
{
      public static int numberOfClicks = 5;
      public static bool timerEnabled;

      // Harvest methods must be seperate for each resource for game balancing.
      // Gather 1 Wood: 10%
      // Gather 2 Wood: 20%
      // Gather 3 Wood: 40%
      // Gather 4 Wood: 20%
      // Gather 5 Wood: 10%
      public void harvestWood()
      {
            // Resource can still be harvested!
            if (numberOfClicks > 0 && timerEnabled == true)
            {
                  // Used to determine "luck" of how many resources are gathered.
                  int randomNumber = RNG.randomNumberGenerator();

                  if (randomNumber <= 10)
                  {
                        Resources.setWood(Resources.getWood() + 1);
                  }

                  else if (randomNumber <= 30)
                  {
                        Resources.setWood(Resources.getWood() + 2);
                  }

                  else if (randomNumber <= 70)
                  {
                        Resources.setWood(Resources.getWood() + 3);
                  }

                  else if (randomNumber <= 90)
                  {
                        Resources.setWood(Resources.getWood() + 4);
                  }

                  else
                  {
                        Resources.setWood(Resources.getWood() + 5);
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

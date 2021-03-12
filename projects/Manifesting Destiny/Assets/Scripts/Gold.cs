using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gold : MonoBehaviour
{
      public int numberOfClicks = 5;
      public static bool timerEnabled;

      // Harvest methods must be seperate for each resource for game balancing.
      // Gather 1 Gold: 10%
      // Gather 2 Gold: 20%
      // Gather 3 Gold: 40%
      // Gather 4 Gold: 20%
      // Gather 5 Gold: 10%
      public void harvestGold()
      {
            // Resource can still be harvested!
            if (numberOfClicks > 0 && timerEnabled == true)
            {
                  // Used to determine "luck" of how many resources are gathered.
                  int randomNumber = RNG.randomNumberGenerator();

                  if (randomNumber <= 10)
                  {
                        Resources.setGold(Resources.getGold() + 1);
                  }

                  else if (randomNumber <= 30)
                  {
                        Resources.setGold(Resources.getGold() + 2);
                  }

                  else if (randomNumber <= 70)
                  {
                        Resources.setGold(Resources.getGold() + 3);
                  }

                  else if (randomNumber <= 90)
                  {
                        Resources.setGold(Resources.getGold() + 4);
                  }

                  else
                  {
                        Resources.setGold(Resources.getGold() + 5);
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

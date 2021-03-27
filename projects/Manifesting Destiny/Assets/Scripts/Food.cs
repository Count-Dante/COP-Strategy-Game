using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Food : MonoBehaviour
{
      public GameObject PopUpTextPrefab;
      public int numberOfClicks = 5;
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
                        if (PopUpTextPrefab != null)
                        {
                              ShowText("+1");
                        }
                  }

                  else if (randomNumber <= 30)
                  {
                        Resources.setFood(Resources.getFood() + 2);
                        if (PopUpTextPrefab != null)
                        {
                              ShowText("+2");
                        }
                  }

                  else if (randomNumber <= 70)
                  {
                        Resources.setFood(Resources.getFood() + 3);
                        if (PopUpTextPrefab != null)
                        {
                              ShowText("+3");
                        }
                  }

                  else if (randomNumber <= 90)
                  {
                        Resources.setFood(Resources.getFood() + 4);
                        if (PopUpTextPrefab != null)
                        {
                              ShowText("+4");
                        }
                  }

                  else
                  {
                        Resources.setFood(Resources.getFood() + 5);
                        if (PopUpTextPrefab != null)
                        {
                              ShowText("+5");
                        }
                  }

                  // Decrement the number of clicks remaining for this tile.
                  numberOfClicks -= 1;
            }
      }

      void ShowText(string myText)
      {
            // Create clone of the Text Prefab.
            GameObject Text = Instantiate(PopUpTextPrefab, transform.position, Quaternion.identity, transform);
            Text.GetComponent<UnityEngine.UI.Text>().text = myText;

            double textOffset = (double)Screen.height * 0.1;
            Vector3 temp = new Vector3(0, (float)textOffset, 0);
            Text.transform.position += temp;

            Destroy(Text, 1);
      }

      void Update()
      {
            timerEnabled = Timer.getTimerStatus();
      }

}

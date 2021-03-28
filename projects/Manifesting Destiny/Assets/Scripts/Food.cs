using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Food : MonoBehaviour
{
      public GameObject PopUpTextPrefab;
      public int numberOfClicks = 5;
      public static bool timerEnabled;
      private double [,] textPositionArray = new double[5, 2] {
                        { (double)Screen.width * -0.0125, (double)Screen.height * 0.055},
                        { (double)Screen.width *  0.025, (double)Screen.height * 0.055},
                        { (double)Screen.width *  0.000, (double)Screen.height * 0.055},
                        { (double)Screen.width *  -0.025, (double)Screen.height * 0.055},
                        { (double)Screen.width * 0.0125, (double)Screen.height * 0.055}
                  };

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
                        // Create pop up text for the amount harvested
                        if (PopUpTextPrefab != null)
                              ShowText("+1");
                  }

                  else if (randomNumber <= 30)
                  {
                        Resources.setFood(Resources.getFood() + 2);
                        if (PopUpTextPrefab != null)
                              ShowText("+2");
                  }

                  else if (randomNumber <= 70)
                  {
                        Resources.setFood(Resources.getFood() + 3);
                        if (PopUpTextPrefab != null)
                              ShowText("+3");
                  }

                  else if (randomNumber <= 90)
                  {
                        Resources.setFood(Resources.getFood() + 4);
                        if (PopUpTextPrefab != null)
                              ShowText("+4");
                  }

                  else
                  {
                        Resources.setFood(Resources.getFood() + 5);
                        if (PopUpTextPrefab != null)
                              ShowText("+5");
                  }

                  // Decrement the number of clicks remaining for this tile.
                  numberOfClicks -= 1;
            }
      }

      void ShowText(string amount)
      {
            // Create clone of the Text Prefab.
            GameObject Text = Instantiate(PopUpTextPrefab, transform.position, Quaternion.identity, transform);
            // Set text to the amount harvested (passed to funtion).
            Text.GetComponent<UnityEngine.UI.Text>().text = amount;

            // Set horizontal position (changing) and vertical position (constant) from array declared above.
            double textHorizontalOffset = textPositionArray[numberOfClicks - 1, 0];
            double textVerticalOffset = textPositionArray[numberOfClicks - 1, 1];
            // Create a vector to be added to the text's current position (centered on tile).
            Vector3 temp = new Vector3((float)textHorizontalOffset, (float)textVerticalOffset, 0);
            Text.transform.position += temp;
            // Properly scale the object.
            Text.transform.localScale = Vector3.one;

            // Detroy (clean up) text object after 1 second (already disappeared).
            Destroy(Text, 1);
      }

      void Update()
      {
            timerEnabled = Timer.getTimerStatus();
      }

}

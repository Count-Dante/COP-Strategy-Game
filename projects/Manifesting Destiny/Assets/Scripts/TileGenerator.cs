using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TileGenerator : MonoBehaviour
{
      // EDIT SCRIPT: replace individual objects with array that creates and accesses objects
      public GameObject Tree1;
      public GameObject Tree2;
      public GameObject Tree3;
      public GameObject Tree4;
      public GameObject Tree5;
      public GameObject Tree6;
      public GameObject Tree7;
      public GameObject Tree8;
      public GameObject Tree9;
      public GameObject Tree10;
      public GameObject Farm1;
      public GameObject Farm2;
      public GameObject Farm3;
      public GameObject Farm4;
      public GameObject Farm5;
      public GameObject Farm6;
      public GameObject Farm7;
      public GameObject Mine1;
      public GameObject Mine2;
      public GameObject Mine3;
      public GameObject grid;

      private double x;
      private double y;
      // Provides border around the edge of the screen that is 1% the height of the screen.
      private double margin;
      // Accounts for margin at the top and the bottom of the screen.
      private double verticalRange;
      // Accounts for margin at the top and the bottom of the screen.
      private double horizontalRange;
      // Array that holds valid positions of objects.
      // {set, x-coordinate, y-coordinate}
      double[,] positions = new double[86, 3];

      void Start()
      {
            grid.SetActive(true);
            setPositionsArray();
            setWoodTiles();
            setFoodTiles();
            setGoldTiles();
      }

      void Update()
      {
            Debug.Log(Screen.height);
            Debug.Log(Screen.width);
      }

      public void setWoodTiles()
      {
            for (int i = 0; i < 10; i++)
            {
                  // Select random index.
                  int index = RNG.randomNumberGenerator();

                  // Ensure index is valid and that position is not already occupied.
                  while (index > 85 || positions[index, 0] == 1)
                  {
                        index = RNG.randomNumberGenerator();
                  }

                  // Set position as taken.
                  positions[index, 0] = 1;
                  x = positions[index, 1];
                  y = positions[index, 2];

                  // Create vector to move the object to the position.
                  Vector3 temp = new Vector3((float)(x), (float)(y), 0);
                  // When replaced with object array, set Object[i].position = temp
                  if (i == 0)
                        Tree1.transform.position = temp;
                  else if (i == 1)
                        Tree2.transform.position = temp;
                  else if (i == 2)
                        Tree3.transform.position = temp;
                  else if (i == 3)
                        Tree4.transform.position = temp;
                  else if (i == 4)
                        Tree5.transform.position = temp;
                  else if (i == 5)
                        Tree6.transform.position = temp;
                  else if (i == 6)
                        Tree7.transform.position = temp;
                  else if (i == 7)
                        Tree8.transform.position = temp;
                  else if (i == 8)
                        Tree9.transform.position = temp;
                  else
                        Tree10.transform.position = temp;
            }
      }

      public void setFoodTiles()
      {
            for (int i = 0; i < 7; i++)
            {
                  // Select random index.
                  int index = RNG.randomNumberGenerator();

                  // Ensure index is valid and that position is not already occupied.
                  while (index > 85 || positions[index, 0] == 1)
                  {
                        index = RNG.randomNumberGenerator();
                  }

                  // Set position as taken.
                  positions[index, 0] = 1;
                  x = positions[index, 1];
                  y = positions[index, 2];

                  // Create vector to move the object to the position.
                  Vector3 temp = new Vector3((float)(x), (float)(y), 0);
                  // When replaced with object array, set Object[i].position = temp
                  if (i == 0)
                        Farm1.transform.position = temp;
                  else if (i == 1)
                        Farm2.transform.position = temp;
                  else if (i == 2)
                        Farm3.transform.position = temp;
                  else if (i == 3)
                        Farm4.transform.position = temp;
                  else if (i == 4)
                        Farm5.transform.position = temp;
                  else if (i == 5)
                        Farm6.transform.position = temp;
                  else
                        Farm7.transform.position = temp;
            }
      }

      public void setGoldTiles()
      {
            for (int i = 0; i < 3; i++)
            {
                  // Select random index.
                  int index = RNG.randomNumberGenerator();

                  // Ensure index is valid and that position is not already occupied.
                  while (index > 85 || positions[index, 0] == 1)
                  {
                        index = RNG.randomNumberGenerator();
                  }

                  // Set position as taken.
                  positions[index, 0] = 1;
                  x = positions[index, 1];
                  y = positions[index, 2];

                  // Create vector to move the object to the position.
                  Vector3 temp = new Vector3((float)(x), (float)(y), 0);
                  // When replaced with object array, set Object[i].position = temp
                  if (i == 0)
                        Mine1.transform.position = temp;
                  else if (i == 1)
                        Mine2.transform.position = temp;
                  else
                        Mine3.transform.position = temp;
            }
      }

      // This function explains the complex logic of setting each position
      public void setPositionsArray()
      {
            // 1. First a margin is created around the screen that is 1% of the screen's height.
            // 2. This margin is then subtracted off all 4 sides of the screen to give us a new
            //    width (Screen.width - (2 * margin)) and height Screen.height - (2 * margin).
            // 3. Using this new "range", we then divide the vertical area into 16 sections, and
            //    the horizontal area into 30 sections.
            // 4. Using the odd indices of these sections gives us 8 valid vertical placements and
            //    15 valid horizontal placements.
            // 5. Some of these placements are occupied by UI elements, and objects can not be
            //    placed there (in the first 5 x-coordinates and the last 3 x-coordinates).

            margin = (double)Screen.height * 0.01;
            verticalRange = (double)Screen.height - (2 * margin);
            horizontalRange = (double)Screen.width - (2 * margin);

            double[,] temp = new double[86, 3] {
                              { 0, horizontalRange * 1/30 + margin, verticalRange * 3/16 + margin},
                              { 0, horizontalRange * 1/30 + margin, verticalRange * 5/16 + margin},
                              { 0, horizontalRange * 1/30 + margin, verticalRange * 7/16 + margin},
                              { 0, horizontalRange * 1/30 + margin, verticalRange * 9/16 + margin},
                              { 0, horizontalRange * 1/30 + margin, verticalRange * 11/16 + margin},

                              { 0, horizontalRange * 3/30 + margin, verticalRange * 3/16 + margin},
                              { 0, horizontalRange * 3/30 + margin, verticalRange * 5/16 + margin},
                              { 0, horizontalRange * 3/30 + margin, verticalRange * 7/16 + margin},
                              { 0, horizontalRange * 3/30 + margin, verticalRange * 9/16 + margin},
                              { 0, horizontalRange * 3/30 + margin, verticalRange * 11/16 + margin},

                              { 0, horizontalRange * 5/30 + margin, verticalRange * 3/16 + margin},
                              { 0, horizontalRange * 5/30 + margin, verticalRange * 5/16 + margin},
                              { 0, horizontalRange * 5/30 + margin, verticalRange * 7/16 + margin},
                              { 0, horizontalRange * 5/30 + margin, verticalRange * 9/16 + margin},
                              { 0, horizontalRange * 5/30 + margin, verticalRange * 11/16 + margin},

                              { 0, horizontalRange * 7/30 + margin, verticalRange * 3/16 + margin},
                              { 0, horizontalRange * 7/30 + margin, verticalRange * 5/16 + margin},
                              { 0, horizontalRange * 7/30 + margin, verticalRange * 7/16 + margin},
                              { 0, horizontalRange * 7/30 + margin, verticalRange * 9/16 + margin},
                              { 0, horizontalRange * 7/30 + margin, verticalRange * 11/16 + margin},

                              { 0, horizontalRange * 9/30 + margin, verticalRange * 3/16 + margin},
                              { 0, horizontalRange * 9/30 + margin, verticalRange * 5/16 + margin},
                              { 0, horizontalRange * 9/30 + margin, verticalRange * 7/16 + margin},
                              { 0, horizontalRange * 9/30 + margin, verticalRange * 9/16 + margin},
                              { 0, horizontalRange * 9/30 + margin, verticalRange * 11/16 + margin},

                              { 0, horizontalRange * 11/30 + margin, verticalRange * 3/16 + margin},
                              { 0, horizontalRange * 11/30 + margin, verticalRange * 5/16 + margin},
                              { 0, horizontalRange * 11/30 + margin, verticalRange * 7/16 + margin},
                              { 0, horizontalRange * 11/30 + margin, verticalRange * 9/16 + margin},
                              { 0, horizontalRange * 11/30 + margin, verticalRange * 11/16 + margin},
                              { 0, horizontalRange * 11/30 + margin, verticalRange * 13/16 + margin},
                              { 0, horizontalRange * 11/30 + margin, verticalRange * 15/16 + margin},

                              { 0, horizontalRange * 13/30 + margin, verticalRange * 3/16 + margin},
                              { 0, horizontalRange * 13/30 + margin, verticalRange * 5/16 + margin},
                              { 0, horizontalRange * 13/30 + margin, verticalRange * 7/16 + margin},
                              { 0, horizontalRange * 13/30 + margin, verticalRange * 9/16 + margin},
                              { 0, horizontalRange * 13/30 + margin, verticalRange * 11/16 + margin},
                              { 0, horizontalRange * 13/30 + margin, verticalRange * 13/16 + margin},
                              { 0, horizontalRange * 13/30 + margin, verticalRange * 15/16 + margin},

                              { 0, horizontalRange * 15/30 + margin, verticalRange * 3/16 + margin},
                              { 0, horizontalRange * 15/30 + margin, verticalRange * 5/16 + margin},
                              { 0, horizontalRange * 15/30 + margin, verticalRange * 7/16 + margin},
                              { 0, horizontalRange * 15/30 + margin, verticalRange * 9/16 + margin},
                              { 0, horizontalRange * 15/30 + margin, verticalRange * 11/16 + margin},
                              { 0, horizontalRange * 15/30 + margin, verticalRange * 13/16 + margin},
                              { 0, horizontalRange * 15/30 + margin, verticalRange * 15/16 + margin},

                              { 0, horizontalRange * 17/30 + margin, verticalRange * 3/16 + margin},
                              { 0, horizontalRange * 17/30 + margin, verticalRange * 5/16 + margin},
                              { 0, horizontalRange * 17/30 + margin, verticalRange * 7/16 + margin},
                              { 0, horizontalRange * 17/30 + margin, verticalRange * 9/16 + margin},
                              { 0, horizontalRange * 17/30 + margin, verticalRange * 11/16 + margin},
                              { 0, horizontalRange * 17/30 + margin, verticalRange * 13/16 + margin},
                              { 0, horizontalRange * 17/30 + margin, verticalRange * 15/16 + margin},

                              { 0, horizontalRange * 19/30 + margin, verticalRange * 3/16 + margin},
                              { 0, horizontalRange * 19/30 + margin, verticalRange * 5/16 + margin},
                              { 0, horizontalRange * 19/30 + margin, verticalRange * 7/16 + margin},
                              { 0, horizontalRange * 19/30 + margin, verticalRange * 9/16 + margin},
                              { 0, horizontalRange * 19/30 + margin, verticalRange * 11/16 + margin},
                              { 0, horizontalRange * 19/30 + margin, verticalRange * 13/16 + margin},
                              { 0, horizontalRange * 19/30 + margin, verticalRange * 15/16 + margin},

                              { 0, horizontalRange * 21/30 + margin, verticalRange * 3/16 + margin},
                              { 0, horizontalRange * 21/30 + margin, verticalRange * 5/16 + margin},
                              { 0, horizontalRange * 21/30 + margin, verticalRange * 7/16 + margin},
                              { 0, horizontalRange * 21/30 + margin, verticalRange * 9/16 + margin},
                              { 0, horizontalRange * 21/30 + margin, verticalRange * 11/16 + margin},
                              { 0, horizontalRange * 21/30 + margin, verticalRange * 13/16 + margin},
                              { 0, horizontalRange * 21/30 + margin, verticalRange * 15/16 + margin},

                              { 0, horizontalRange * 23/30 + margin, verticalRange * 3/16 + margin},
                              { 0, horizontalRange * 23/30 + margin, verticalRange * 5/16 + margin},
                              { 0, horizontalRange * 23/30 + margin, verticalRange * 7/16 + margin},
                              { 0, horizontalRange * 23/30 + margin, verticalRange * 9/16 + margin},
                              { 0, horizontalRange * 23/30 + margin, verticalRange * 11/16 + margin},
                              { 0, horizontalRange * 23/30 + margin, verticalRange * 13/16 + margin},
                              { 0, horizontalRange * 23/30 + margin, verticalRange * 15/16 + margin},

                              { 0, horizontalRange * 25/30 + margin, verticalRange * 3/16 + margin},
                              { 0, horizontalRange * 25/30 + margin, verticalRange * 5/16 + margin},
                              { 0, horizontalRange * 25/30 + margin, verticalRange * 7/16 + margin},
                              { 0, horizontalRange * 25/30 + margin, verticalRange * 9/16 + margin},

                              { 0, horizontalRange * 27/30 + margin, verticalRange * 3/16 + margin},
                              { 0, horizontalRange * 27/30 + margin, verticalRange * 5/16 + margin},
                              { 0, horizontalRange * 27/30 + margin, verticalRange * 7/16 + margin},
                              { 0, horizontalRange * 27/30 + margin, verticalRange * 9/16 + margin},

                              { 0, horizontalRange * 29/30 + margin, verticalRange * 3/16 + margin},
                              { 0, horizontalRange * 29/30 + margin, verticalRange * 5/16 + margin},
                              { 0, horizontalRange * 29/30 + margin, verticalRange * 7/16 + margin},
                              { 0, horizontalRange * 29/30 + margin, verticalRange * 9/16 + margin},
                        };

            positions = temp;
      }
}

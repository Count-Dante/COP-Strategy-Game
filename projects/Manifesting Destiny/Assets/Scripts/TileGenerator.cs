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

      double x;
      double y;
      double height = Screen.height;
      double width = Screen.width;

      double[,] positions = new double[86, 3] {
                        // {is set, y-cord, x-cord}
                        { 0, 70 + (120 * 7), 70 + (114.66 * 5)}, { 0, 70 + (120 * 7), 70 + (114.66 * 6)},
                        { 0, 70 + (120 * 7), 70 + (114.66 * 7)}, { 0, 70 + (120 * 7), 70 + (114.66 * 8)},
                        { 0, 70 + (120 * 7), 70 + (114.66 * 9)}, { 0, 70 + (120 * 7), 70 + (114.66 * 10)},
                        { 0, 70 + (120 * 7), 70 + (114.66 * 11)},

                        { 0, 70 + (120 * 6), 70 + (114.66 * 5)}, { 0, 70 + (120 * 6), 70 + (114.66 * 6)},
                        { 0, 70 + (120 * 6), 70 + (114.66 * 7)}, { 0, 70 + (120 * 6), 70 + (114.66 * 8)},
                        { 0, 70 + (120 * 6), 70 + (114.66 * 9)}, { 0, 70 + (120 * 6), 70 + (114.66 * 10)},
                        { 0, 70 + (120 * 6), 70 + (114.66 * 11)},

                        { 0, 70 + (120 * 5), 70 + (114.66 * 0)}, { 0, 70 + (120 * 5), 70 + (114.66 * 1)},
                        { 0, 70 + (120 * 5), 70 + (114.66 * 2)}, { 0, 70 + (120 * 5), 70 + (114.66 * 3)},
                        { 0, 70 + (120 * 5), 70 + (114.66 * 4)}, { 0, 70 + (120 * 5), 70 + (114.66 * 5)},
                        { 0, 70 + (120 * 5), 70 + (114.66 * 6)}, { 0, 70 + (120 * 5), 70 + (114.66 * 7)},
                        { 0, 70 + (120 * 5), 70 + (114.66 * 8)}, { 0, 70 + (120 * 5), 70 + (114.66 * 9)},
                        { 0, 70 + (120 * 5), 70 + (114.66 * 10)}, { 0, 70 + (120 * 5), 70 + (114.66 * 11)},

                        { 0, 70 + (120 * 4), 70 + (114.66 * 0)}, { 0, 70 + (120 * 4), 70 + (114.66 * 1)},
                        { 0, 70 + (120 * 4), 70 + (114.66 * 2)}, { 0, 70 + (120 * 4), 70 + (114.66 * 3)},
                        { 0, 70 + (120 * 4), 70 + (114.66 * 4)}, { 0, 70 + (120 * 4), 70 + (114.66 * 5)},
                        { 0, 70 + (120 * 4), 70 + (114.66 * 6)}, { 0, 70 + (120 * 4), 70 + (114.66 * 7)},
                        { 0, 70 + (120 * 4), 70 + (114.66 * 8)}, { 0, 70 + (120 * 4), 70 + (114.66 * 9)},
                        { 0, 70 + (120 * 4), 70 + (114.66 * 10)}, { 0, 70 + (120 * 4), 70 + (114.66 * 11)},
                        { 0, 70 + (120 * 4), 70 + (114.66 * 12)}, { 0, 70 + (120 * 4), 70 + (114.66 * 13)},
                        { 0, 70 + (120 * 4), 70 + (114.66 * 14)},

                        { 0, 70 + (120 * 3), 70 + (114.66 * 0)}, { 0, 70 + (120 * 3), 70 + (114.66 * 1)},
                        { 0, 70 + (120 * 3), 70 + (114.66 * 2)}, { 0, 70 + (120 * 3), 70 + (114.66 * 3)},
                        { 0, 70 + (120 * 3), 70 + (114.66 * 4)}, { 0, 70 + (120 * 3), 70 + (114.66 * 5)},
                        { 0, 70 + (120 * 3), 70 + (114.66 * 6)}, { 0, 70 + (120 * 3), 70 + (114.66 * 7)},
                        { 0, 70 + (120 * 3), 70 + (114.66 * 8)}, { 0, 70 + (120 * 3), 70 + (114.66 * 9)},
                        { 0, 70 + (120 * 3), 70 + (114.66 * 10)}, { 0, 70 + (120 * 3), 70 + (114.66 * 11)},
                        { 0, 70 + (120 * 3), 70 + (114.66 * 12)}, { 0, 70 + (120 * 3), 70 + (114.66 * 13)},
                        { 0, 70 + (120 * 3), 70 + (114.66 * 14)},

                        { 0, 70 + (120 * 2), 70 + (114.66 * 0)}, { 0, 70 + (120 * 2), 70 + (114.66 * 1)},
                        { 0, 70 + (120 * 2), 70 + (114.66 * 2)}, { 0, 70 + (120 * 2), 70 + (114.66 * 3)},
                        { 0, 70 + (120 * 2), 70 + (114.66 * 4)}, { 0, 70 + (120 * 2), 70 + (114.66 * 5)},
                        { 0, 70 + (120 * 2), 70 + (114.66 * 6)}, { 0, 70 + (120 * 2), 70 + (114.66 * 7)},
                        { 0, 70 + (120 * 2), 70 + (114.66 * 8)}, { 0, 70 + (120 * 2), 70 + (114.66 * 9)},
                        { 0, 70 + (120 * 2), 70 + (114.66 * 10)}, { 0, 70 + (120 * 2), 70 + (114.66 * 11)},
                        { 0, 70 + (120 * 2), 70 + (114.66 * 12)}, { 0, 70 + (120 * 2), 70 + (114.66 * 13)},
                        { 0, 70 + (120 * 2), 70 + (114.66 * 14)},

                        { 0, 70 + (120 * 1), 70 + (114.66 * 0)}, { 0, 70 + (120 * 1), 70 + (114.66 * 1)},
                        { 0, 70 + (120 * 1), 70 + (114.66 * 2)}, { 0, 70 + (120 * 1), 70 + (114.66 * 3)},
                        { 0, 70 + (120 * 1), 70 + (114.66 * 4)}, { 0, 70 + (120 * 1), 70 + (114.66 * 5)},
                        { 0, 70 + (120 * 1), 70 + (114.66 * 6)}, { 0, 70 + (120 * 1), 70 + (114.66 * 7)},
                        { 0, 70 + (120 * 1), 70 + (114.66 * 8)}, { 0, 70 + (120 * 1), 70 + (114.66 * 9)},
                        { 0, 70 + (120 * 1), 70 + (114.66 * 10)}, { 0, 70 + (120 * 1), 70 + (114.66 * 11)},
                        { 0, 70 + (120 * 1), 70 + (114.66 * 12)}, { 0, 70 + (120 * 1), 70 + (114.66 * 13)},
                        { 0, 70 + (120 * 1), 70 + (114.66 * 14)}
                  };

      void Start()
      {
            grid.SetActive(true);
            setWoodTiles();
            setFoodTiles();
            setGoldTiles();
      }

      void Update()
      {
            Debug.Log("good");
      }

      public void setWoodTiles()
      {
            for (int i = 0; i < 10; i++)
            {
                  int index = RNG.randomNumberGenerator();

                  while (index > 85 || positions[index, 0] == 1)
                  {
                        index = RNG.randomNumberGenerator();
                  }

                  positions[index, 0] = 1;
                  y = positions[index, 1];
                  x = positions[index, 2];

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
                  int index = RNG.randomNumberGenerator();

                  while (index > 85 || positions[index, 0] == 1)
                  {
                        index = RNG.randomNumberGenerator();
                  }

                  positions[index, 0] = 1;
                  y = positions[index, 1];
                  x = positions[index, 2];

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
                  int index = RNG.randomNumberGenerator();

                  while (index > 85 || positions[index, 0] == 1)
                  {
                        index = RNG.randomNumberGenerator();
                  }

                  positions[index, 0] = 1;
                  y = positions[index, 1];
                  x = positions[index, 2];

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
}

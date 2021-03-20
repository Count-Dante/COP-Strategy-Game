using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TileGenerator : MonoBehaviour
{
      GameObject [] Trees;
      GameObject [] Farms;
      GameObject [] Mines;
      public int numberOfTrees;
      public int numberOfFarms;
      public int numberOfMines;
      public GameObject TreePrefab;
      public GameObject FarmPrefab;
      public GameObject MinePrefab;
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
            // Used for debugging. For final game set grid.SetActive to false.
            grid.SetActive(true);
            setObjectArrays();
            setPositionsArray();
            setTilePositions();
            disablePrefabs();
      }

      void Update()
      {
            Debug.Log(Screen.height);
            Debug.Log(Screen.width);
      }

      // This function temporarily disables GameObject Tiles while acessing menus.
      public void disableTiles()
      {
            for (int i = 0; i < Trees.Length; i++)
            {
                  Trees[i].SetActive(false);
            }

            for (int i = 0; i < Farms.Length; i++)
            {
                  Farms[i].SetActive(false);
            }

            for (int i = 0; i < Mines.Length; i++)
            {
                  Mines[i].SetActive(false);
            }
      }

      public void enableTiles()
      {
            for (int i = 0; i < Trees.Length; i++)
            {
                  Trees[i].SetActive(true);
            }

            for (int i = 0; i < Farms.Length; i++)
            {
                  Farms[i].SetActive(true);
            }

            for (int i = 0; i < Mines.Length; i++)
            {
                  Mines[i].SetActive(true);
            }
      }

      // This function sets the position of the Tree tiles.
      public void setTreeTiles()
      {
            for (int i = 0; i < Trees.Length; i++)
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
                  Trees[i].transform.position = temp;
            }
      }

      // This function sets the position of the Farm tiles.
      public void setFarmTiles()
      {
            for (int i = 0; i < Farms.Length; i++)
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
                  Farms[i].transform.position = temp;
            }
      }

      // This function sets the position of the Mine tiles.
      public void setMineTiles()
      {
            for (int i = 0; i < Mines.Length; i++)
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
                  Mines[i].transform.position = temp;
            }
      }

      public void setTilePositions()
      {
            setTreeTiles();
            setFarmTiles();
            setMineTiles();
      }

      public void disablePrefabs()
      {
            TreePrefab.SetActive(false);
            FarmPrefab.SetActive(false);
            MinePrefab.SetActive(false);
      }

      // This function instantiates Tile GameObjects and places them in their corresponding array.
      public void setObjectArrays()
      {
            GameObject[] tempTrees = new GameObject[numberOfTrees];

            for (int i = 0; i < tempTrees.Length; i++)
            {
                  // Create clone of the Tree Prefab.
                  GameObject Tree = Instantiate(TreePrefab, new Vector3(0, 0, 0), Quaternion.identity) as GameObject;
                  // Move that object to the correct layer to appear in-game.
                  Tree.transform.SetParent (GameObject.FindGameObjectWithTag("MainCamera").transform, true);
                  Tree.transform.SetParent (GameObject.FindGameObjectWithTag("Canvas").transform, true);
                  // Insert new object into array to be accessed later.
                  tempTrees[i] = Tree;
            }

            GameObject[] tempFarms = new GameObject[numberOfFarms];

            for (int i = 0; i < tempFarms.Length; i++)
            {
                  // Create clone of the Farm Prefab.
                  GameObject Farm = Instantiate(FarmPrefab, new Vector3(0, 0, 0), Quaternion.identity) as GameObject;
                  // Move that object to the correct layer to appear in-game.
                  Farm.transform.SetParent (GameObject.FindGameObjectWithTag("MainCamera").transform, true);
                  Farm.transform.SetParent (GameObject.FindGameObjectWithTag("Canvas").transform, true);
                  // Insert new object into array to be accessed later.
                  tempFarms[i] = Farm;
            }

            GameObject[] tempMines = new GameObject[numberOfMines];

            for (int i = 0; i < tempMines.Length; i++)
            {
                  // Create clone of the Mine Prefab.
                  GameObject Mine = Instantiate(MinePrefab, new Vector3(0, 0, 0), Quaternion.identity) as GameObject;
                  // Move that object to the correct layer to appear in-game.
                  Mine.transform.SetParent (GameObject.FindGameObjectWithTag("MainCamera").transform, true);
                  Mine.transform.SetParent (GameObject.FindGameObjectWithTag("Canvas").transform, true);
                  // Insert new object into array to be accessed later.
                  tempMines[i] = Mine;
            }

            // Update fields.
            Trees = tempTrees;
            Farms = tempFarms;
            Mines = tempMines;
      }

      // This function explains the complex logic of setting each position.
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

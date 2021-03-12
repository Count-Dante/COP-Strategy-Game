using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// This class is used when restarting the game entirely.
// Ensures that all previously saved data from the scene gets reset.
public class RestartGame : MonoBehaviour
{
  public void resetExpansionPoints()
  {
    ExpansionController.wood = 0;
    ExpansionController.food = 0;
    ExpansionController.gold = 0;

    ExpansionBar.expansionPoint = 0;
  }

  public void resetDefensePoints()
  {
    DefenseController.wood = 0;
    DefenseController.food = 0;
    DefenseController.gold = 0;

    DefenseBar.defensePoint = 0;
  }

  public void resetBadRNG()
  {
    BadRNG.deadGame = false;
  }

  public void resetResources()
  {
    Resources.totalFood = 0;
    Resources.totalGold = 0;
    Resources.totalWood = 0;
  }

}

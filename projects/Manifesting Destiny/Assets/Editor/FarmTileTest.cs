using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using NUnit.Framework;
using UnityEngine.UI;

public class FarmTileTest
{
  bool buttonClicked = false;

  [Test]
  public void buttonClickedTest()
  {
    Button farmButton;
    farmButton = GameObject.Find("FarmTile").GetComponent<Button>();

    farmButton.onClick.AddListener(() => farmOnClick());
    farmButton.onClick.Invoke();

    Assert.IsTrue(buttonClicked == true);
  }

  public void farmOnClick()
  {
    buttonClicked = true;
  }

  [Test]
  public void gatherFoodTest()
  {
    Button treeButton = GameObject.Find("FarmTile").GetComponent<Button>();

    treeButton.onClick.AddListener(() => harvestOnClick());
    treeButton.onClick.Invoke();

    Assert.IsTrue(Resources.getFood() <= 5 && Resources.getFood() > 0);
  }

  public void harvestOnClick()
  {
    GameObject gameObject = new GameObject();
    Food tile = gameObject.AddComponent<Food>();
    tile.harvestFood();
  }
}

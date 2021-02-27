using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using NUnit.Framework;
using UnityEngine.UI;

public class TreeTileTest
{
  bool buttonClicked = false;

  [Test]
  public void buttonClickedTest()
  {
    Button treeButton = GameObject.Find("TreeTile").GetComponent<Button>();

    treeButton.onClick.AddListener(() => treeOnClick());
    treeButton.onClick.Invoke();

    Assert.IsTrue(buttonClicked == true);
  }

  public void treeOnClick()
  {
    buttonClicked = true;
  }

  [Test]
  public void gatherWoodTest()
  {
    Button treeButton = GameObject.Find("TreeTile").GetComponent<Button>();

    treeButton.onClick.AddListener(() => harvestOnClick());
    treeButton.onClick.Invoke();

    Assert.IsTrue(Resources.getWood() <= 5 && Resources.getWood() > 0);
  }

  public void harvestOnClick()
  {
    GameObject gameObject = new GameObject();
    Wood tile = gameObject.AddComponent<Wood>();
    tile.harvestWood();
  }
}

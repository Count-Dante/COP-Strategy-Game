using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using NUnit.Framework;
using UnityEngine.UI;

public class MineTileTest
{
  bool buttonClicked = false;

  [Test]
  public void buttonClickedTest()
  {
    Button mineButton = GameObject.Find("MineTile").GetComponent<Button>();

    mineButton.onClick.AddListener(() => mineOnClick());
    mineButton.onClick.Invoke();

    Assert.IsTrue(buttonClicked == true);
  }

  public void mineOnClick()
  {
    buttonClicked = true;
  }

  [Test]
  public void gatherGoldTest()
  {
    Button mineButton = GameObject.Find("MineTile").GetComponent<Button>();

    mineButton.onClick.AddListener(() => harvestOnClick());
    mineButton.onClick.Invoke();

    Assert.IsTrue(Resources.getGold() <= 5 && Resources.getGold() > 0);
    Resources.setGold(0);
  }

  public void harvestOnClick()
  {
    GameObject gameObject = new GameObject();
    Gold tile = gameObject.AddComponent<Gold>();
    Gold.timerEnabled = true;
    tile.harvestGold();
    Gold.timerEnabled = false;
  }

}

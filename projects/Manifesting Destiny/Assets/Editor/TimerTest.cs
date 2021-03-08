using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using NUnit.Framework;
using UnityEngine.UI;


public class TimerTest
{
  [Test]
  public void timerDisabledAllowsNoGoldCollectionTest()
  {
    Button mineButton = GameObject.Find("MineTile").GetComponent<Button>();

    mineButton.onClick.AddListener(() => harvestGoldOnClickTimerDisabled());
    mineButton.onClick.Invoke();

    Assert.IsTrue(Resources.getGold() == 0);
  }

  public void harvestGoldOnClickTimerDisabled()
  {
    GameObject gameObject = new GameObject();
    Gold tile = gameObject.AddComponent<Gold>();
    Gold.timerEnabled = false;
    // harvesting gold should have incremented resource by at least one
    tile.harvestGold();
  }

  [Test]
  public void timerEnabledAllowsGoldCollectionTest()
  {
    Button mineButton = GameObject.Find("MineTile").GetComponent<Button>();

    mineButton.onClick.AddListener(() => harvestGoldOnClickTimerEnabled());
    mineButton.onClick.Invoke();

    Assert.IsTrue(Resources.getGold() > 0);
  }

  public void harvestGoldOnClickTimerEnabled()
  {
    GameObject gameObject = new GameObject();
    Gold tile = gameObject.AddComponent<Gold>();
    Gold.timerEnabled = true;
    tile.harvestGold();
  }

  [Test]
  public void timerDisabledAllowsNoFoodCollectionTest()
  {
    Button farmButton = GameObject.Find("FarmTile").GetComponent<Button>();

    farmButton.onClick.AddListener(() => harvestFoodOnClickTimerDisabled());
    farmButton.onClick.Invoke();

    Assert.IsTrue(Resources.getFood() == 0);
  }

  public void harvestFoodOnClickTimerDisabled()
  {
    GameObject gameObject = new GameObject();
    Food tile = gameObject.AddComponent<Food>();
    Food.timerEnabled = false;
    tile.harvestFood();
  }

  [Test]
  public void timerEnabledAllowsFoodCollectionTest()
  {
    Button farmButton = GameObject.Find("FarmTile").GetComponent<Button>();

    farmButton.onClick.AddListener(() => harvestFoodOnClickTimerEnabled());
    farmButton.onClick.Invoke();

    Assert.IsTrue(Resources.getFood() > 0);
  }

  public void harvestFoodOnClickTimerEnabled()
  {
    GameObject gameObject = new GameObject();
    Food tile = gameObject.AddComponent<Food>();
    Food.timerEnabled = true;
    tile.harvestFood();
  }

  [Test]
  public void timerDisabledAllowsNoWoodCollectionTest()
  {
    Button treeButton = GameObject.Find("TreeTile").GetComponent<Button>();

    treeButton.onClick.AddListener(() => harvestWoodOnClickTimerDisabled());
    treeButton.onClick.Invoke();

    Assert.IsTrue(Resources.getWood() == 0);
  }

  public void harvestWoodOnClickTimerDisabled()
  {
    GameObject gameObject = new GameObject();
    Wood tile = gameObject.AddComponent<Wood>();
    Wood.timerEnabled = false;
    tile.harvestWood();
  }

  [Test]
  public void timerEnabledAllowsWoodCollectionTest()
  {
    Button woodButton = GameObject.Find("TreeTile").GetComponent<Button>();

    woodButton.onClick.AddListener(() => harvestWoodOnClickTimerEnabled());
    woodButton.onClick.Invoke();

    Assert.IsTrue(Resources.getWood() > 0);
  }

  public void harvestWoodOnClickTimerEnabled()
  {
    GameObject gameObject = new GameObject();
    Wood tile = gameObject.AddComponent<Wood>();
    Wood.timerEnabled = true;
    tile.harvestWood();
  }


}

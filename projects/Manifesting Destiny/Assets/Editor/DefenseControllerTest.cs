using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using NUnit.Framework;
using UnityEngine.UI;

public class DefenseControllerTest
{
  [Test]
  public void allocateWood()
  {
    Resources.setWood(20);
    // Allocate 4 wood to Expansion
    DefenseController.wood = 10;

    GameObject gameObject = new GameObject();
    DefenseController inventory = gameObject.AddComponent<DefenseController>();

    inventory.removeResources();

    Assert.IsTrue(Resources.getWood() == 10);
  }

  [Test]
  public void allocateNoWood()
  {
    Resources.setWood(20);
    DefenseController.wood = 0;

    GameObject gameObject = new GameObject();
    DefenseController inventory = gameObject.AddComponent<DefenseController>();

    inventory.removeResources();

    Assert.IsTrue(Resources.getWood() == 20);
  }

  [Test]
  public void allocateGold()
  {
    Resources.setGold(20);
    DefenseController.gold = 10;

    GameObject gameObject = new GameObject();
    DefenseController inventory = gameObject.AddComponent<DefenseController>();

    inventory.removeResources();

    Assert.IsTrue(Resources.getGold() == 10);
  }

  [Test]
  public void allocateNoGold()
  {
    Resources.setGold(20);
    DefenseController.gold = 0;

    GameObject gameObject = new GameObject();
    DefenseController inventory = gameObject.AddComponent<DefenseController>();

    inventory.removeResources();

    Assert.IsTrue(Resources.getGold() == 20);
  }

  [Test]
  public void allocateFood()
  {
    Resources.setFood(20);
    DefenseController.food = 10;

    GameObject gameObject = new GameObject();
    DefenseController inventory = gameObject.AddComponent<DefenseController>();

    inventory.removeResources();

    Assert.IsTrue(Resources.getFood() == 10);
  }

  [Test]
  public void allocateNoFood()
  {
    Resources.setFood(20);
    DefenseController.food = 0;

    GameObject gameObject = new GameObject();
    DefenseController inventory = gameObject.AddComponent<DefenseController>();

    inventory.removeResources();

    Assert.IsTrue(Resources.getFood() == 20);
  }
}

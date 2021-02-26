using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using NUnit.Framework;
using UnityEngine.UI;

public class ExpansionControllerTest
{
    [Test]
    public void allocateWood()
    {
      Resources.setWood(10);
      // Allocate 4 wood to Expansion
      ExpansionController.wood = 4;

      GameObject gameObject = new GameObject();
      ExpansionController inventory = gameObject.AddComponent<ExpansionController>();

      inventory.removeResources();

      Assert.IsTrue(Resources.getWood() == 6);
    }

    [Test]
    public void allocateNoWood()
    {
      Resources.setWood(10);
      ExpansionController.wood = 0;

      GameObject gameObject = new GameObject();
      ExpansionController inventory = gameObject.AddComponent<ExpansionController>();

      inventory.removeResources();

      Assert.IsTrue(Resources.getWood() == 10);
    }

    [Test]
    public void allocateGold()
    {
      Resources.setGold(10);
      ExpansionController.gold = 4;

      GameObject gameObject = new GameObject();
      ExpansionController inventory = gameObject.AddComponent<ExpansionController>();

      inventory.removeResources();

      Assert.IsTrue(Resources.getGold() == 6);
    }

    [Test]
    public void allocateNoGold()
    {
      Resources.setGold(10);
      ExpansionController.gold = 0;

      GameObject gameObject = new GameObject();
      ExpansionController inventory = gameObject.AddComponent<ExpansionController>();

      inventory.removeResources();

      Assert.IsTrue(Resources.getGold() == 10);
    }

    [Test]
    public void allocateFood()
    {
      Resources.setFood(10);
      ExpansionController.food = 4;

      GameObject gameObject = new GameObject();
      ExpansionController inventory = gameObject.AddComponent<ExpansionController>();

      inventory.removeResources();

      Assert.IsTrue(Resources.getFood() == 6);
    }

    [Test]
    public void allocateNoFood()
    {
      Resources.setFood(10);
      ExpansionController.food = 0;

      GameObject gameObject = new GameObject();
      ExpansionController inventory = gameObject.AddComponent<ExpansionController>();

      inventory.removeResources();

      Assert.IsTrue(Resources.getFood() == 10);
    }
}

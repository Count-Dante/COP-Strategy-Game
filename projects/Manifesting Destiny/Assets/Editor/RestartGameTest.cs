using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using NUnit.Framework;

public class RestartGameTest
{
    [Test]
    public void resetExpansionPointsTest()
    {
      ExpansionController.wood = 10;
      ExpansionController.food = 10;
      ExpansionController.gold = 10;

      RestartGame.resetExpansionPoints();
      Assert.IsTrue(ExpansionController.wood == 0 && ExpansionController.food == 0
      && ExpansionController.gold == 0);
    }

    [Test]
    public void resetDefensePointsTest()
    {
      DefenseController.wood = 10;
      DefenseController.food = 10;
      DefenseController.gold = 10;

      RestartGame.resetDefensePoints();
      Assert.IsTrue(DefenseController.wood == 0 && DefenseController.food == 0
      && DefenseController.gold == 0);
    }

    [Test]
    public void resetResourcesTest()
    {
      Resources.setWood(10);
      Resources.setGold(10);
      Resources.setFood(10);

      RestartGame.resetResources();

      Assert.IsTrue(Resources.getWood() == 0 && Resources.getFood() == 0
      && Resources.getGold() == 0);
    }
}

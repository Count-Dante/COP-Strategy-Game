using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using NUnit.Framework;

public class DefenseCalculatorTest
{
    [Test]
    public void getCurrentDefensePoints_Test()
    {
        DefenseController.food = 2;
        DefenseController.wood = 2;
        DefenseController.gold = 1;
        float expectedPoints = (2 * 3) + (2 * 3) + (1 * 5);

        float points = DefenseBar.getCurrentDefensePoint();

        Assert.That(points, Is.EqualTo(expectedPoints));
    }
}

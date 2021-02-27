using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using NUnit.Framework;

public class ExpansionCalculatorTest
{
    [Test]
    public void getCurrentExpansionPoints_Test()
    {
        ExpansionController.food = 2;
        ExpansionController.wood = 2;
        ExpansionController.gold = 1;
        float expectedPoints = (2 * 5) + (2 * 5) + (1 * 7);

        float points = ExpansionBar.getCurrentExpansionPoint();

        Assert.That(points, Is.EqualTo(expectedPoints));
    }
}

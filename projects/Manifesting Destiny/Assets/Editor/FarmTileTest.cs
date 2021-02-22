using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using NUnit.Framework;
using UnityEngine.UI;

public class FarmTileTest
{
  bool buttonClicked = false;
  
  [Test]
  public void foodTile_Test()
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
}

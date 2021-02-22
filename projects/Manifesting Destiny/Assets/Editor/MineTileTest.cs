using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using NUnit.Framework;
using UnityEngine.UI;

public class MineTileTest
{
  bool buttonClicked = false;

  [Test]
  public void mineTile_Test()
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

}

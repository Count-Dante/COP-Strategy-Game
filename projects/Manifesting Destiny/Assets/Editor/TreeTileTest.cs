using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using NUnit.Framework;
using UnityEngine.UI;

public class TreeTileTest
{
  bool buttonClicked = false;

  [Test]
  public void woodTile_Test()
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
}

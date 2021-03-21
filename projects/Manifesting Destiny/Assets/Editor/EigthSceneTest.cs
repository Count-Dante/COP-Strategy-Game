using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using NUnit.Framework;
using UnityEngine.UI;
using UnityEditor.SceneManagement;
using UnityEngine.SceneManagement;

public class EigthSceneTest
{
  [Test]
  public void LoadGameSceneTest()
  {
    Button button;
    button = GameObject.Find("ExpansionButton").GetComponent<Button>();

    // Call GetGameScene when button is clicked
    button.onClick.AddListener(() => GetGameScene());
    button.onClick.Invoke();

    Scene activeScene = EditorSceneManager.GetActiveScene();
    string activeSceneName = activeScene.name;

    // Test if expected scene name matches current scene.
    Assert.IsTrue(activeSceneName == "EigthSettlement");
  }

  public void GetGameScene()
  {
    EditorSceneManager.OpenScene("Assets/Scenes/EigthSettlement.unity");
  }
}

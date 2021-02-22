using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using NUnit.Framework;
using UnityEngine.UI;
using UnityEditor.SceneManagement;
using UnityEngine.SceneManagement;

public class StartGameTest
{
  [Test]
  public void LoadGameSceneTest()
  {
    Button startButton;
    startButton = GameObject.Find("StartButton").GetComponent<Button>();

    // Call GetGameScene when button is clicked
    startButton.onClick.AddListener(() => GetGameScene());
    startButton.onClick.Invoke();

    Scene activeScene = EditorSceneManager.GetActiveScene();
    string activeSceneName = activeScene.name;

    // Test if expected scene name matches current scene.
    Assert.IsTrue(activeSceneName == "FirstSettlement");
  }

  public void GetGameScene()
  {
    EditorSceneManager.OpenScene("Assets/Scenes/FirstSettlement.unity");
  }
}

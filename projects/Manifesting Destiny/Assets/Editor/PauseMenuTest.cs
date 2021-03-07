using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using NUnit.Framework;
using UnityEngine.UI;
using UnityEditor.SceneManagement;
using UnityEngine.SceneManagement;

public class PauseMenuTest
{
  [Test]
  public void MainMenuSceneTest()
  {
    Button mainMenuButton;
    mainMenuButton = GameObject.Find("/Main Camera/Canvas/PauseMenu/ExitToMainMenuButton").GetComponent<Button>();

    // Call GetGameScene when button is clicked
    mainMenuButton.onClick.AddListener(() => GetGameScene());
    mainMenuButton.onClick.Invoke();

    Scene activeScene = EditorSceneManager.GetActiveScene();
    string activeSceneName = activeScene.name;

    // Test if expected scene name matches current scene.
    Assert.IsTrue(activeSceneName == "MainMenu");
  }

  public void GetGameScene()
  {
    EditorSceneManager.OpenScene("Assets/Scenes/MainMenu.unity");
  }
}

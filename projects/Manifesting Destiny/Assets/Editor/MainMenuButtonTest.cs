using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using NUnit.Framework;
using UnityEngine.UI;
using UnityEditor.SceneManagement;
using UnityEngine.SceneManagement;

public class MainMenuButtonTest
{
  [Test]
  public void LoadMainMenuSceneTest()
  {
    Button returnToMainMenu;
    returnToMainMenu = GameObject.Find("PostRNG/dead/MainMenuButton").GetComponent<Button>();

    // Call GetGameScene when button is clicked
    returnToMainMenu.onClick.AddListener(() => GetGameScene());
    returnToMainMenu.onClick.Invoke();

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

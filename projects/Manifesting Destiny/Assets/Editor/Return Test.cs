using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using NUnit.Framework;
using UnityEngine.UI;
using UnityEditor.SceneManagement;
using UnityEngine.SceneManagement;

public class ReturnTest
{
  [Test]
  public void ReturnToMainMenuSceneTest()
  {
      Button returnButton;
      returnButton = GameObject.Find("Return Button").GetComponent<Button>();

      returnButton.onClick.AddListener(() => GetGameScene());
      returnButton.onClick.Invoke();

      Scene activeScene = EditorSceneManager.GetActiveScene();
      string activeSceneName = activeScene.name;

      Assert.IsTrue(activeSceneName == "MainMenu");
  }

  public void GetGameScene()
  {
     EditorSceneManager.OpenScene("Assets/Scenes/MainMenu.unity");
  }
}

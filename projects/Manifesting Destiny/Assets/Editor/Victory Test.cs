using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using NUnit.Framework;
using UnityEngine.UI;
using UnityEditor.SceneManagement;
using UnityEngine.SceneManagement;

public class VictoryTest
{
    [Test]
    public void LoadVictorySceneTest()
    {
        Button victoryButton;
        victoryButton = GameObject.Find("Victory Button").GetComponent<Button>();

        victoryButton.onClick.AddListener(() => GetGameScene());
        victoryButton.onClick.Invoke();

        Scene activeScene = EditorSceneManager.GetActiveScene();
        string activeSceneName = activeScene.name;

        Assert.IsTrue(activeSceneName == "Victory");
    }

    public void GetGameScene()
    {
       EditorSceneManager.OpenScene("Assets/Scenes/Victory.unity");
    }
}

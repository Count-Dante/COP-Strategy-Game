using System.IO;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using NUnit.Framework;
using UnityEditor.SceneManagement;
using UnityEngine.SceneManagement;

public class LoadGameTest
{

    /* Automated Test for saving and loading games
     * Pseudocode:
     * -------------------------------------------
     * Click 'load game x' to start that game.
     * 
     * Save the game to a save file, serves the same
     * purpose as hitting the expansion button as an
     * autosave.
     * 
     * Load that save file.
     * 
     * Verify the second settlement scene is loaded
     * after loading the perviously saved file.
     * 
     * Why? Initial scene when loading a new save is the
     * first settlement, a successful save (first autosave)
     * and load would load the second settlement.
    */


    [Test]
    public void testSave1()
    {
        // This function clears all previously created test saves.
        clearTests();

        // Attaches the save/load script to a game object.
        GameObject gameObject = new GameObject();
        tSaveData saveData = gameObject.AddComponent<tSaveData>();

        // Click load game 1.
        saveData.LoadGame("save1t");
        // Autosave game 1 after expansion.
        saveData.SaveGame();
        // Load game 1 again.
        saveData.LoadGame("save1t");

        // Check what the active scene is.
        Scene activeScene = EditorSceneManager.GetActiveScene();
        string activeSceneName = activeScene.name;

        // Verify the second settlement scene loaded correctly.
        Assert.IsTrue(activeSceneName == "SecondSettlement");
    }


    [Test]
    public void testSave2()
    {
        GameObject gameObject = new GameObject();
        tSaveData saveData = gameObject.AddComponent<tSaveData>();

        saveData.LoadGame("save2t");
        saveData.SaveGame();
        saveData.LoadGame("save2t");
        Scene activeScene = EditorSceneManager.GetActiveScene();
        string activeSceneName = activeScene.name;

        Assert.IsTrue(activeSceneName == "SecondSettlement");
    }

    [Test]
    public void testSave3()
    {

        GameObject gameObject = new GameObject();
        tSaveData saveData = gameObject.AddComponent<tSaveData>();

        saveData.LoadGame("save3t");
        saveData.SaveGame();
        saveData.LoadGame("save3t");
        Scene activeScene = EditorSceneManager.GetActiveScene();
        string activeSceneName = activeScene.name;

        Assert.IsTrue(activeSceneName == "SecondSettlement");
    }

    [Test]
    public void testSave4()
    {

        GameObject gameObject = new GameObject();
        tSaveData saveData = gameObject.AddComponent<tSaveData>();

        saveData.LoadGame("save4t");
        saveData.SaveGame();
        saveData.LoadGame("save4t");
        Scene activeScene = EditorSceneManager.GetActiveScene();
        string activeSceneName = activeScene.name;

        Assert.IsTrue(activeSceneName == "SecondSettlement");
    }

    [Test]
    public void testSave5()
    {
        GameObject gameObject = new GameObject();
        tSaveData saveData = gameObject.AddComponent<tSaveData>();

        saveData.LoadGame("save5t");
        saveData.SaveGame();
        saveData.LoadGame("save5t");
        Scene activeScene = EditorSceneManager.GetActiveScene();
        string activeSceneName = activeScene.name;

        Assert.IsTrue(activeSceneName == "SecondSettlement");
    }

    /* Automated Test for deleting saves 
    *  Pseudocode 
    * -------------------------------------------
    * The save files are created befopre the clear
    * test is run (!!!)
    * 
    * Use the clear function to clear a given save
    * Verify that save file does not exist
    * Return true if so
   */

    [Test]
    public void testSave1Clear()
    {

        // Attach the clear all script to a game object.
        GameObject gameObject = new GameObject();
        clearAll ClearAll = gameObject.AddComponent<clearAll>();

        // Destination where the test save SHOULD be.
        string destination = Application.persistentDataPath + "/save1t.dat";

        // Clear function for deletion and assert file was successfully deleted.
        ClearAll.clear("save1t");
        Assert.IsTrue(!File.Exists(destination));

    }

    [Test]
    public void testSave2Clear()
    {

        GameObject gameObject = new GameObject();
        clearAll ClearAll = gameObject.AddComponent<clearAll>();

        string destination = Application.persistentDataPath + "/save2t.dat";
        ClearAll.clear("save2t");
        Assert.IsTrue(!File.Exists(destination));

    }

    [Test]
    public void testSave3Clear()
    {

        GameObject gameObject = new GameObject();
        clearAll ClearAll = gameObject.AddComponent<clearAll>();

        string destination = Application.persistentDataPath + "/save3t.dat";
        ClearAll.clear("save3t");
        Assert.IsTrue(!File.Exists(destination));

    }

    [Test]
    public void testSave4Clear()
    {

        GameObject gameObject = new GameObject();
        clearAll ClearAll = gameObject.AddComponent<clearAll>();

        string destination = Application.persistentDataPath + "/save4t.dat";
        ClearAll.clear("save4t");
        Assert.IsTrue(!File.Exists(destination));

    }

    [Test]
    public void testSave5Clear()
    {

        GameObject gameObject = new GameObject();
        clearAll ClearAll = gameObject.AddComponent<clearAll>();

        string destination = Application.persistentDataPath + "/save5t.dat";
        ClearAll.clear("save5t");
        Assert.IsTrue(!File.Exists(destination));

    }

    // Function that iterates through potential locations of test saves and deletes them once found.
    public void clearTests()
    {
        for (int i = 1; i < 6; i++)
        {
            string destination = Application.persistentDataPath + "/save" + i + "t.dat";
            if (File.Exists(destination))
                File.Delete(destination);
        }
    }
}

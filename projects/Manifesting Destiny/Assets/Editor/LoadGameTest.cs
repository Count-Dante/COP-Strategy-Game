using System.IO;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using NUnit.Framework;

public class LoadGameTest
{

    /* Automated Test for saving and loading games
     * Pseudocode:
     * -------------------------------------------
     * Click 'load game x' to start that game.
     * 
     * Set wood, gold, food amounts to 10.
     * 
     * Set timer remaining timer 25, defense bar
     * to 10 and expansion bar to 10.
     * 
     * Save the game to a save file.
     * 
     * Load that save file.
     * 
     * Verify the loaded save values match those
     * previously set.
    */


        [Test]
        public void testSave1()
        {

            GameObject gameObject = new GameObject();
            Resources resources = gameObject.AddComponent<Resources>();
            Timer timer = gameObject.AddComponent<Timer>();
            DefenseBar defenseBar = gameObject.AddComponent<DefenseBar>();
            ExpansionBar expansionBar = gameObject.AddComponent<ExpansionBar>();
            SaveData saveData = gameObject.AddComponent<SaveData>();

            saveData.LoadGame("save1t");

            Resources.setWood(10);
            Resources.setGold(10);
            Resources.setFood(10);

            Timer.remainingTime = 25;
            DefenseBar.defensePoint = 10;
            ExpansionBar.expansionPoint = 10;

            saveData.SaveGame();
            saveData.LoadGame("save1t");

            Assert.IsTrue(Resources.getWood() == 10 && Resources.getGold() == 10 && Resources.getFood() == 10
               && Timer.remainingTime == 25 && DefenseBar.defensePoint == 10 && ExpansionBar.expansionPoint == 10);
        }

        [Test]
        public void testSave2()
        {

        GameObject gameObject = new GameObject();
        Resources resources = gameObject.AddComponent<Resources>();
        Timer timer = gameObject.AddComponent<Timer>();
        DefenseBar defenseBar = gameObject.AddComponent<DefenseBar>();
        ExpansionBar expansionBar = gameObject.AddComponent<ExpansionBar>();
        SaveData saveData = gameObject.AddComponent<SaveData>();
        saveData.LoadGame("save2t");

            Resources.setWood(10);
            Resources.setGold(10);
            Resources.setFood(10);

            Timer.remainingTime = 25;
            DefenseBar.defensePoint = 10;
            ExpansionBar.expansionPoint = 10;

            saveData.SaveGame();
            saveData.LoadGame("save2t");

            Assert.IsTrue(Resources.getWood() == 10 && Resources.getGold() == 10 && Resources.getFood() == 10
               && Timer.remainingTime == 25 && DefenseBar.defensePoint == 10 && ExpansionBar.expansionPoint == 10);
        }

        [Test]
        public void testSave3()
        {

        GameObject gameObject = new GameObject();
        Resources resources = gameObject.AddComponent<Resources>();
        Timer timer = gameObject.AddComponent<Timer>();
        DefenseBar defenseBar = gameObject.AddComponent<DefenseBar>();
        ExpansionBar expansionBar = gameObject.AddComponent<ExpansionBar>();
        SaveData saveData = gameObject.AddComponent<SaveData>();

        saveData.LoadGame("save3t");

            Resources.setWood(10);
            Resources.setGold(10);
            Resources.setFood(10);

            Timer.remainingTime = 25;
            DefenseBar.defensePoint = 10;
            ExpansionBar.expansionPoint = 10;

            saveData.SaveGame();
            saveData.LoadGame("save3t");

            Assert.IsTrue(Resources.getWood() == 10 && Resources.getGold() == 10 && Resources.getFood() == 10
               && Timer.remainingTime == 25 && DefenseBar.defensePoint == 10 && ExpansionBar.expansionPoint == 10);
        }

        [Test]
        public void testSave4()
        {

        GameObject gameObject = new GameObject();
        Resources resources = gameObject.AddComponent<Resources>();
        Timer timer = gameObject.AddComponent<Timer>();
        DefenseBar defenseBar = gameObject.AddComponent<DefenseBar>();
        ExpansionBar expansionBar = gameObject.AddComponent<ExpansionBar>();
        SaveData saveData = gameObject.AddComponent<SaveData>();

        saveData.LoadGame("save4t");

            Resources.setWood(10);
            Resources.setGold(10);
            Resources.setFood(10);

            Timer.remainingTime = 25;
            DefenseBar.defensePoint = 10;
            ExpansionBar.expansionPoint = 10;

            saveData.SaveGame();
            saveData.LoadGame("save4t");

            Assert.IsTrue(Resources.getWood() == 10 && Resources.getGold() == 10 && Resources.getFood() == 10
               && Timer.remainingTime == 25 && DefenseBar.defensePoint == 10 && ExpansionBar.expansionPoint == 10);
        }

        [Test]
        public void testSave5()
        {

        GameObject gameObject = new GameObject();
        Resources resources = gameObject.AddComponent<Resources>();
        Timer timer = gameObject.AddComponent<Timer>();
        DefenseBar defenseBar = gameObject.AddComponent<DefenseBar>();
        ExpansionBar expansionBar = gameObject.AddComponent<ExpansionBar>();
        SaveData saveData = gameObject.AddComponent<SaveData>();

        saveData.LoadGame("save5t");

            Resources.setWood(10);
            Resources.setGold(10);
            Resources.setFood(10);

            Timer.remainingTime = 25;
            DefenseBar.defensePoint = 10;
            ExpansionBar.expansionPoint = 10;

            saveData.SaveGame();
            saveData.LoadGame("save5t");

            Assert.IsTrue(Resources.getWood() == 10 && Resources.getGold() == 10 && Resources.getFood() == 10
               && Timer.remainingTime == 25 && DefenseBar.defensePoint == 10 && ExpansionBar.expansionPoint == 10);
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
        public void testSave1Clear() {

            GameObject gameObject = new GameObject();
            clearAll ClearAll = gameObject.AddComponent<clearAll>();

            string destination = Application.persistentDataPath + "/save1t.dat";
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

}

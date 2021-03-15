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

        saveData.LoadGame("save1");

        Resources.setWood(10);
        Resources.setGold(10);
        Resources.setFood(10);

        Timer.remainingTime = 25;
        DefenseBar.defensePoint = 10;
        ExpansionBar.expansionPoint = 10;

        saveData.SaveGame();
        saveData.LoadGame("save1");

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
        saveData.LoadGame("save2");

            Resources.setWood(10);
            Resources.setGold(10);
            Resources.setFood(10);

            Timer.remainingTime = 25;
            DefenseBar.defensePoint = 10;
            ExpansionBar.expansionPoint = 10;

            saveData.SaveGame();
            saveData.LoadGame("save2");

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

        saveData.LoadGame("save3");

            Resources.setWood(10);
            Resources.setGold(10);
            Resources.setFood(10);

            Timer.remainingTime = 25;
            DefenseBar.defensePoint = 10;
            ExpansionBar.expansionPoint = 10;

            saveData.SaveGame();
            saveData.LoadGame("save3");

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

        saveData.LoadGame("save4");

            Resources.setWood(10);
            Resources.setGold(10);
            Resources.setFood(10);

            Timer.remainingTime = 25;
            DefenseBar.defensePoint = 10;
            ExpansionBar.expansionPoint = 10;

            saveData.SaveGame();
            saveData.LoadGame("save4");

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

        saveData.LoadGame("save5");

            Resources.setWood(10);
            Resources.setGold(10);
            Resources.setFood(10);

            Timer.remainingTime = 25;
            DefenseBar.defensePoint = 10;
            ExpansionBar.expansionPoint = 10;

            saveData.SaveGame();
            saveData.LoadGame("save5");

            Assert.IsTrue(Resources.getWood() == 10 && Resources.getGold() == 10 && Resources.getFood() == 10
               && Timer.remainingTime == 25 && DefenseBar.defensePoint == 10 && ExpansionBar.expansionPoint == 10);
        }
    }

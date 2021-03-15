using UnityEngine;
using UnityEngine.UI;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

public class SaveData : MonoBehaviour
{
    // Variables to store game data.
    float defensePoints = 0;
    float expansionPoints = 0;
    float remainingTime = 0;

    int wood = 0;
    int gold = 0;
    int food = 0;

    // Static string to hold the name of the current save
    public static string curSave;

    // Function to save the game.
    public void SaveGame()
    {

        // File path for the current save file loaded.
        string destination = Application.persistentDataPath + "/" + curSave + ".dat";

        FileStream file;

        // If the save exists, open it. Else, create a file for the save.
        if (File.Exists(destination))
            file = File.OpenWrite(destination);
        else
            file = File.Create(destination);

        // Setting the game data from the current game.
        remainingTime = Timer.remainingTime;
        defensePoints = DefenseBar.defensePoint;
        expansionPoints = ExpansionBar.expansionPoint;

        wood = Resources.getWood();
        gold = Resources.getGold();
        food = Resources.getFood();

        // Creation of a GameData object to store the game data.
        GameData data = new GameData(remainingTime, defensePoints, expansionPoints, wood, gold, food);

        // Game data is seralized and stored in the file.
        BinaryFormatter bf = new BinaryFormatter();
        bf.Serialize(file, data);
        file.Close();
    }

    public void LoadGame(string loadName)
    {

        // Sets the current save file loaded.
        curSave = loadName;

        // Path of the save file.
        string destination = Application.persistentDataPath + "/" + loadName + ".dat";
        FileStream file;

        // If the save file exists, read else create it.
        if (File.Exists(destination))
            file = File.OpenRead(destination);
        else
        {
            file = File.Create(destination);
            file.Close();
            return;
        }


        // Attempt to deserialize the saved game data, error thrown if file is empty.
        try
        {
            BinaryFormatter bf = new BinaryFormatter();
            GameData data = (GameData)bf.Deserialize(file);
            file.Close();

            Timer.remainingTime = data.remainingTime;
            DefenseBar.defensePoint = data.defensePoints;
            ExpansionBar.expansionPoint = data.expansionPoints;

            Resources.setWood(data.wood);
            Resources.setGold(data.gold);
            Resources.setFood(data.food);

        }

        // File is empty, insert initial values to avoid errors.
        catch
        {
            Timer.remainingTime = 25;
            DefenseBar.defensePoint = 0;
            ExpansionBar.expansionPoint = 0;

            Resources.setWood(0);
            Resources.setGold(0);
            Resources.setFood(0);

            file.Close();
        }
    }
}

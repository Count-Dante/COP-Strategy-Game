using UnityEngine;
using UnityEngine.UI;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

public class SaveData : MonoBehaviour
{

    float defensePoints = 0;
    float expansionPoints = 0;

    int wood = 0;
    int gold = 0;
    int food = 0;

    // Update is called once per frame
    public void SaveGame()
    {
        string destination = Application.persistentDataPath + "/save.dat";
        FileStream file;

        Debug.Log(destination);

        if (File.Exists(destination))
            file = File.OpenWrite(destination);
        else
            file = File.Create(destination);

        defensePoints = DefenseBar.defensePoint;
        expansionPoints = ExpansionBar.expansionPoint;

        wood = Resources.getWood();
        gold = Resources.getGold();
        food = Resources.getFood();

        GameData data = new GameData(defensePoints, expansionPoints, wood, gold, food);
        Debug.Log(data.wood);
        BinaryFormatter bf = new BinaryFormatter();
        bf.Serialize(file, data);
        file.Close();
    }

    public void LoadGame()
    {
        string destination = Application.persistentDataPath + "/save.dat";
        FileStream file;

        if (File.Exists(destination))
            file = File.OpenRead(destination);
        else
        {
            Debug.LogError("No file found.");
            return;
        }

        BinaryFormatter bf = new BinaryFormatter();
        GameData data = (GameData)bf.Deserialize(file);
        file.Close();

        DefenseBar.defensePoint = data.defensePoints;
        ExpansionBar.expansionPoint = data.expansionPoints;


        Resources.setWood(data.wood);
        Resources.setGold(data.gold);
        Resources.setFood(data.food);

        Debug.Log(data.wood + " load");
    }
}

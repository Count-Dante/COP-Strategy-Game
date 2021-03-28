using UnityEngine;
using UnityEngine.UI;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using UnityEditor.SceneManagement;
using UnityEngine.SceneManagement;

// !!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
// This a slightly modified version of the SaveData script that handles the save and load functions.
// The automated test runner for unity loads unity scenes through a function called EditorSceneManager
// whereas in play scenes are called through a function called SceneManager. That is the only modification
// to the script implemented in game.
// !!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!

public class tSaveData : MonoBehaviour
{
    // Variables to current scene names and the time the game was created or saved.
    string scene;
    string time;


    // Static string to hold the name of the current save.
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
        time = System.DateTime.Now.ToString("dd/MM/yy hh:mm");

        // When the expansion button is pressed, the next scene is loaded and the progression
        // to that scene is saved. If the current scene when the button is pressed is the first
        // settlement, then the next scene / level to be loaded would be the second level and so
        // on.
        if (string.Equals(EditorSceneManager.GetActiveScene().name, "FirstSettlement"))
            scene = "SecondSettlement";

        else if (string.Equals(EditorSceneManager.GetActiveScene().name, "SecondSettlement"))
            scene = "ThirdSettlement";

        else if (string.Equals(EditorSceneManager.GetActiveScene().name, "ThirdSettlement"))
            scene = "FourthSettlement";

        else if (string.Equals(EditorSceneManager.GetActiveScene().name, "FourthSettlement"))
            scene = "FifthSettlement";

        else if (string.Equals(EditorSceneManager.GetActiveScene().name, "FifthSettlement"))
            scene = "SixthSettlement";

        else if (string.Equals(EditorSceneManager.GetActiveScene().name, "SixthSettlement"))
            scene = "SeventhSettlement";

        else if (string.Equals(EditorSceneManager.GetActiveScene().name, "SeventhSettlement"))
            scene = "EigthSettlement";

        else if (string.Equals(EditorSceneManager.GetActiveScene().name, "EigthSettlement"))
            scene = "NinthSettlement";

        else if (string.Equals(EditorSceneManager.GetActiveScene().name, "NinthSettlement"))
            scene = "Settlement";

        else if (string.Equals(EditorSceneManager.GetActiveScene().name, "TenthSettlement"))
            scene = "Victory";
        else
            scene = "FirstSettlement";


        // Creation of a GameData object to store the game data.
        GameData data = new GameData(time, scene);

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

            time = System.DateTime.Now.ToString("dd/MM/yy hh:mm");
            scene = "FirstSettlement";

            GameData data = new GameData(time, scene);
            BinaryFormatter bf = new BinaryFormatter();
            bf.Serialize(file, data);
            file.Close();
            EditorSceneManager.OpenScene("Assets/Scenes/FirstSettlement.unity");
            return;
        }


        // Attempt to deserialize the saved game data, error thrown if file is empty.
        try
        {
            BinaryFormatter bf = new BinaryFormatter();
            GameData data = (GameData)bf.Deserialize(file);
            file.Close();
            EditorSceneManager.OpenScene("Assets/Scenes/" + data.scene + ".unity");
        }

        // File is empty, insert initial values to avoid errors.
        catch
        {

            time = System.DateTime.Now.ToString("dd/MM/yy hh:mm");
            scene = "FirstSettlement";
            file.Close();
            EditorSceneManager.OpenScene("Assets/Scenes/FirstSettlement.unity");
        }
    }
}

using UnityEngine;
using UnityEngine.UI;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;


public class clearAll : MonoBehaviour
{

    // The clearAll class contains functions to both clear all current save files
    // and clear individual save files.

    // Clears all save files
    public void clear_All()
    {
        // Loops through the locations of save files 1-5, if it exists delete it!
        for (int i = 1; i < 6; i++) {
            string destination = Application.persistentDataPath + "/save" + i + ".dat";
            if (File.Exists(destination))
                File.Delete(destination);
        }
    }

    // Clears an individual save file
    public void clear(string loadName)
    {
        // Destination of save file
        string destination = Application.persistentDataPath + "/" + loadName + ".dat";

        // If the file exists, delete it!
        if (File.Exists(destination))
            File.Delete(destination);
    }
}

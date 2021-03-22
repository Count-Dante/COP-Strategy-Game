using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

public class update1 : MonoBehaviour
{

    /* Every update1-5 script after this is the same as this one, thus the
     * comments are the same. Different scripts were created since the start
     * function runs when the object its attached to is loaded and they are all
     * attached to individual text boxes next to buttons to load saves.
     */

    // Object to store the date
    public Text date;

    void Start()
    {

        // Destination of the save file and buffer "file" to serve as filestream
        string destination = Application.persistentDataPath + "/save1.dat";
        FileStream file;

        // If the save file exists, read else create it.
        date = gameObject.GetComponent<UnityEngine.UI.Text>();

        // if the file exists, open it and read the date written on the save.
        if (File.Exists(destination))
        {
            file = File.OpenRead(destination);
            BinaryFormatter bf = new BinaryFormatter();
            GameData data = (GameData)bf.Deserialize(file);
            file.Close();
            // Change the date of the save next to the save file on the mnenu.
            date.text = data.time;
        }

        // Otherwise note that the save file is empty since no save file exists.
        else
        {
            date.text = "empty";
            return;
        }
    }

    // Continuously run the start function (not the best practice) to check for any changes or
    // deletions to the save file to update the date.
    void Update()
    {
        Start();
    }
}

using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

public class update2 : MonoBehaviour
{
    public Text date;

    void Start()
    {
        string destination = Application.persistentDataPath + "/save2.dat";
        FileStream file;

        // If the save file exists, read else create it.
        date = gameObject.GetComponent<UnityEngine.UI.Text>();

        if (File.Exists(destination))
        {
            file = File.OpenRead(destination);
            BinaryFormatter bf = new BinaryFormatter();
            GameData data = (GameData)bf.Deserialize(file);
            file.Close();
            date.text = data.time;
        }
        else
        {
            date.text = "empty";
            return;
        }
    }

    void Update()
    {
        Start();
    }
}

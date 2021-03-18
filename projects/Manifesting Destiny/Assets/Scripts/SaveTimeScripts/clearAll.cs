using UnityEngine;
using UnityEngine.UI;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;


public class clearAll : MonoBehaviour
{
    public void clear_All()
    {


        for (int i = 1; i < 6; i++) {
            string destination = Application.persistentDataPath + "/save" + i + ".dat";
            if (File.Exists(destination))
                File.Delete(destination);

            Debug.Log(destination);
        }
    }

    public void clear(string loadName)
    {
        FileStream file;

        string destination = Application.persistentDataPath + "/" + loadName + ".dat";

        if (File.Exists(destination))
            File.Delete(destination);
    }
}

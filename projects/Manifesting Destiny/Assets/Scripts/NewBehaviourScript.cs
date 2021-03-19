using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
      public GameObject go;

    // Start is called before the first frame update
    void Start()
    {
          GameObject enemy = Instantiate(go, new Vector3(0, 0, 0), Quaternion.identity) as GameObject;
          enemy.transform.SetParent (GameObject.FindGameObjectWithTag("MainCamera").transform, true);
          enemy.transform.SetParent (GameObject.FindGameObjectWithTag("Canvas").transform, true);

    }
}

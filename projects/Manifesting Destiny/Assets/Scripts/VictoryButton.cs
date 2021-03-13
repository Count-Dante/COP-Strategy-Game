using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class VictoryButton : MonoBehaviour
{
    public void Victory()
    {
       SceneManager.LoadScene("Victory");
    }
}

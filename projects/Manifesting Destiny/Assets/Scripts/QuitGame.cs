using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuitGame : MonoBehaviour
{
    public void ExitGame()
    {
        // If it's in the Unity Editor, this will close it

        // If it's being run as an application, this will quit the application
        Application.Quit();
    }
}

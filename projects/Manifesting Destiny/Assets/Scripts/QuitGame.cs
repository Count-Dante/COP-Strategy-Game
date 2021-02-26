using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuitGame : MonoBehaviour
{
    public void QuitTheGame()
    {
        // Close/exit the game
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}

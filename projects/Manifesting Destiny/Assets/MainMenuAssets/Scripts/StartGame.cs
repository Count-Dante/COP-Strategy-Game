using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartGame : MonoBehaviour
{
    public void PlayGame ()
    {
      // Game scene is one index away from current main menu scene in the build index.
      SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}

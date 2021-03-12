using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FailedSoundManager : MonoBehaviour
{

  public AudioSource failedSource;
  public AudioSource backgroundSource;
  private bool flag = false;

  void Start()
  {
    flag = false;
  }

  void Update()
  {
    if (BadRNG.isGameDead() == true && flag == false)
      activateSound();
  }

  public void activateSound()
  {
    backgroundSource.Stop();
    failedSource.Play();
    // ensure activateSound() is played only once.
    flag = true;
  }
}

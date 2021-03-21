using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayBackgroundSound : MonoBehaviour
{
  public AudioSource failedSource;
  public AudioSource backgroundSource;

  void Start()
  {
    activateBackgroundSound();
  }

  public void activateBackgroundSound()
  {
    backgroundSource.Play();
    failedSource.Stop();
  }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
      public float totalTime = 25f;
      public static float remainingTime;
      public static bool timerEnabled;
      public GameObject timerText;
      Image timerBar;

      // Start is called before the first frame update
      void Start()
      {
            startTimer();
            timerText.SetActive(false);
            timerBar = GetComponent<Image>();
            remainingTime = totalTime;
      }

      // Update is called once per frame
      void Update()
      {
            if (remainingTime > 0 && timerEnabled == true)
            {
                  remainingTime -= Time.deltaTime;
                  timerBar.fillAmount = remainingTime / totalTime;
            }

            else if (timerEnabled == false)
            {
            }

            else
            {
                  timerEnabled = false;
                  timerText.SetActive(true);
                  Time.timeScale = 0;
            }
      }

      public void pauseTimer()
      {
            timerEnabled = false;
            timerText.SetActive(false);
      }

      public void startTimer()
      {
            timerEnabled = true;
      }

      public static bool getTimerStatus()
      {
            return timerEnabled;
      }

}

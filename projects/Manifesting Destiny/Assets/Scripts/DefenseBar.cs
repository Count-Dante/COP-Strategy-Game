using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DefenseBar : MonoBehaviour
{
  public static float woodDefensePoint = 0;
  public static float foodDefensePoint = 0;
  public static float goldDefensePoint = 0;

  public Slider slider;
  // Start is called before the first frame update
  void Start()
  {
      slider.maxValue = 50;

      slider.value = getCurrentDefensePoint();
  }

  // Update is called once per frame
  void Update()
  {
      slider.value = getCurrentDefensePoint();
  }

  public static float getCurrentDefensePoint()
  {
      woodDefensePoint = 2 * 5;
      foodDefensePoint = 1 * 5;
      goldDefensePoint = 1 * 7;

      return woodDefensePoint + foodDefensePoint + goldDefensePoint;
  }
}

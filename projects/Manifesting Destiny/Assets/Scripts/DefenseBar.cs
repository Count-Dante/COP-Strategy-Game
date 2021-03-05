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
      DefenseController.defensePoints = getCurrentDefensePoint();

      slider.value = DefenseController.defensePoints;
  }

  public static float getCurrentDefensePoint()
  {
      woodDefensePoint = DefenseController.wood * 5;
      foodDefensePoint = DefenseController.food * 5;
      goldDefensePoint = DefenseController.gold * 7;

      return woodDefensePoint + foodDefensePoint + goldDefensePoint;
  }
}

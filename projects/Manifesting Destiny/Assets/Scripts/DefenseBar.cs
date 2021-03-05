using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DefenseBar : MonoBehaviour
{
  public static float woodDefensePoint = 0;
  public static float foodDefensePoint = 0;
  public static float goldDefensePoint = 0;

  public static float defensePoint = 0;

  public Slider slider;
  // Start is called before the first frame update
  void Start()
  {
      slider.maxValue = DefenseController.defenseMaxValue;;
      slider.value = getCurrentDefensePoint();
  }

  // Update is called once per frame
  void Update()
  {
      slider.value = defensePoint;
      DefenseController.defensePoints = defensePoint;
  }

  public static float getCurrentDefensePoint()
  {
      woodDefensePoint = DefenseController.wood * 3;
      foodDefensePoint = DefenseController.food * 3;
      goldDefensePoint = DefenseController.gold * 5;

      return woodDefensePoint + foodDefensePoint + goldDefensePoint;
  }
}

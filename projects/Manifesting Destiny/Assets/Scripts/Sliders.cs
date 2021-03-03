using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Sliders : MonoBehaviour
{
    public Slider resourceSlider;
    public Text numOfType;
    public int inventory;
    public float resourceAmount;

    public void updateText(float value)
    {
      numOfType.text = value.ToString();
      resourceAmount = value;
    }
}

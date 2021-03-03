using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using TMPro;

public class Indicator : MonoBehaviour
{
    private static int resourceFood = 0;
    private static int resourceGold = 0;
    private static int resourceWood = 0;

    public TextMeshProUGUI resourceAmountFood;
    public TextMeshProUGUI resourceAmountGold;
    public TextMeshProUGUI resourceAmountWood;

    // Start is called before the first frame update
    void Start()
    {
      resourceFood = Resources.getFood();
      resourceGold = Resources.getGold();
      resourceWood = Resources.getWood();

      resourceAmountFood.text = Convert.ToString(resourceFood);
      resourceAmountGold.text = Convert.ToString(resourceGold);
      resourceAmountWood.text = Convert.ToString(resourceWood);

      Debug.Log(resourceFood);
      Debug.Log(resourceGold);
      Debug.Log(resourceWood);
    }

    // Update is called once per frame
    void Update()
    {
      resourceFood = Resources.getFood();
      resourceGold = Resources.getGold();
      resourceWood = Resources.getWood();

      resourceAmountFood.text = Convert.ToString(resourceFood);
      resourceAmountGold.text = Convert.ToString(resourceGold);
      resourceAmountWood.text = Convert.ToString(resourceWood);

      Debug.Log(resourceFood);
      Debug.Log(resourceGold);
      Debug.Log(resourceWood);
    }
}

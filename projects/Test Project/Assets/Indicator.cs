using System.Collections;
using System.Collections.Generic;
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
          resourceAmountFood.text = "0";
          resourceAmountGold.text = "0";
          resourceAmountWood.text = "0";
          Debug.Log(resourceFood);
          Debug.Log(resourceGold);
          Debug.Log(resourceWood);
    }

    // Update is called once per frame
    void Update()
    {
          resourceAmountFood.text = "50";
          resourceAmountGold.text = "50";
          resourceAmountWood.text = "50";
          Debug.Log(resourceFood);
          Debug.Log(resourceGold);
          Debug.Log(resourceWood);
    }
}

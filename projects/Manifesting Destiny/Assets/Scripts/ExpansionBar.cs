using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ExpansionBar : MonoBehaviour
{
    public static float woodExpansionPoint = 0;
    public static float foodExpansionPoint = 0;
    public static float goldExpansionPoint = 0;

    public static float expansionPoint = 0;
    public static float maxExpansionPoint = 0;

    public Slider slider;
    public ExpansionController expand;

    // Start is called before the first frame update
    void Start()
    {
        maxExpansionPoint = expand.getMaxExpansionPoints();
        slider.maxValue = maxExpansionPoint;
        slider.value = expansionPoint;
    }

    // Update is called once per frame
    void Update()
    {
        slider.value = expansionPoint;
        checkToExpand();
    }

    public static float getCurrentExpansionPoint()
    {
        woodExpansionPoint = ExpansionController.wood * 5;
        foodExpansionPoint = ExpansionController.food * 5;
        goldExpansionPoint = ExpansionController.gold * 7;

        return goldExpansionPoint + woodExpansionPoint + foodExpansionPoint;
    }

    public void checkToExpand()
    {
        if (expansionPoint >= maxExpansionPoint)
        {
            expand.setActiveExpansionButton();
        }
    }
}

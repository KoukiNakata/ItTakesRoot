using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NutritionBar : MonoBehaviour
{
    [SerializeField] PlayerStatus playerStatus;
    [SerializeField] Image nutritionBar;
    float maxnutritionVal;//最初の値

    // Start is called before the first frame update
    void Start()
    {
        maxnutritionVal = playerStatus.nutritionVal;
    }

    // Update is called once per frame
    void Update()
    {
        //バーの表示
        nutritionBar.fillAmount = (playerStatus.nutritionVal/maxnutritionVal);

    }
}

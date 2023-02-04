using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class meterCount : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI meter;
    float countMeter;//深さの計測
    [SerializeField] GameStart gameStart;
    [SerializeField] GameEnd gameEnd;
    [SerializeField] GameObject tarObj;
    float startPos;
    // Start is called before the first frame update
    void Start()
    {
        countMeter = 0;
        startPos = tarObj.transform.position.y;

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if(gameStart.flag_start&&!gameEnd.flag_gameEnd)
        {
            //最初の位置からどれだけ進んだか
            countMeter = (startPos- tarObj.transform.position.y);
            //メーターの表示
            meter.text = countMeter.ToString("F1") + "M";
        }
    }
}

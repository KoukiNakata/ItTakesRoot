using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using Cinemachine;


public class GameEnd : MonoBehaviour
{
    public bool flag_gameEnd;//true.ゲームエンド　false.非ゲームエンド
    [SerializeField] GameObject RetryButton;
    [SerializeField] TextMeshProUGUI CountMeter;
    [SerializeField] CinemachineVirtualCamera Vcam;
    [SerializeField] GameObject tarObj;
    

    // Start is called before the first frame update
    void Start()
    {
        flag_gameEnd = false;
    }

    // Update is called once per frame
    void Update()
    {
      
    }

    //ゲームエンド時の処理　ゲームエンドでこの処理を呼び出す
    public void gameEnd()
    {
        flag_gameEnd = true;
        Debug.Log("ゲームエンド");

        //リトライボタンの表示
        RetryButton.SetActive(true);

        //スコア表示
        CountMeter.rectTransform.anchoredPosition=new Vector2(0,0);
        CountMeter.fontSize = 128;
        //


        //最後のカメラの引き
        Vcam.Priority = 2;
        Vcam.transform.position = new Vector3(0,tarObj.transform.position.y,tarObj.transform.position.y*1.5f);
    }

    

}

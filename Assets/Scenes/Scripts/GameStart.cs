using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameStart : MonoBehaviour
{
    public bool flag_start;//true.ゲーム状態　false.非ゲーム状態

    // Start is called before the first frame update
    void Start()
    {
        flag_start = false;
    }

    // Update is called once per frame
    void Update()
    {
        /*
        if(flag_start)
        {
            //ゲーム中の処理
        }
        */
    }

    //ボタンでこの関数を呼び出してゲームスタート？
    public void gameStart()
    {
        flag_start = true;
    }


}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameEnd : MonoBehaviour
{
    public bool flag_gameEnd;//true.ゲームエンド　false.非ゲームエンド
    [SerializeField] GameObject RetryButton;

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
        //ゲームエンド時の処理
        //スコア表示
        //リトライボタンの表示
        RetryButton.SetActive(true);

    }

    

}

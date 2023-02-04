using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreatHurdle : MonoBehaviour
{

    [SerializeField] GameObject[] hurdles;//áŠQ•¨‚ÌŠi”[
    [SerializeField] float span;//áŠQ•¨‚ð¶¬‚·‚éŠÔŠu
     float time;
    [SerializeField] GameObject tarObj;
    [SerializeField] GameStart gameStart;
    [SerializeField] GameEnd gameEnd;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if(gameStart.flag_start&&!gameEnd.flag_gameEnd)
        {
            time += Time.deltaTime;
            if(time>span)
            {
                time = 0;
                float x = Random.Range(2.5f,-2.5f);
                Instantiate(hurdles[0],new Vector3(x,tarObj.transform.position.y-10,0),Quaternion.identity);
            }
        }
    }
}

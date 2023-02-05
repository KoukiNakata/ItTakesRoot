using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreatHurdle : MonoBehaviour
{

    [SerializeField] GameObject[] obstacles;//��Q���̊i�[
    //0 �{���@1 ��@2�@���@3�@���O��
    [SerializeField] float span;//��Q���𐶐�����Ԋu
    float time;
    [SerializeField] GameObject tarObj;
    [SerializeField] GameStart gameStart;
    [SerializeField] GameEnd gameEnd;
    // Start is called before the first frame update
    void Start()
    {
        creatobstacle();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (gameStart.flag_start && !gameEnd.flag_gameEnd)
        {
            /*
            #region ��Q���̐���
            time += Time.deltaTime;
            if(time>span)
            {
                time = 0;
                float x = Random.Range(2.5f,-2.5f);
                Instantiate(hurdles[0],new Vector3(x,tarObj.transform.position.y-10,0),Quaternion.identity);
            }
            #endregion
            */


        }
    }

    void creatobstacle()
    {
        for (int i = 1; i < 100; i++)
        {
            float x = Random.Range(2.5f, -2.5f);

            Instantiate(obstacles[0], new Vector3(x, -15 + (-5 * i), 0), Quaternion.identity);
        }
    }

}

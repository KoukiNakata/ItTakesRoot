using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMove : MonoBehaviour
{

    [SerializeField] float speed;//�J�����̃X�s�[�h
    [SerializeField] GameStart gameStart;
    [SerializeField] GameEnd gameEnd;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        //�t���O�Ŕ���
        if(gameStart.flag_start&&!gameEnd.flag_gameEnd)
        {
            transform.position += new Vector3(0, -speed, 0) * Time.deltaTime;
        }


    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameStart : MonoBehaviour
{
    public bool flag_start;//true.�Q�[����ԁ@false.��Q�[�����

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
            //�Q�[�����̏���
        }
        */
    }

    //�{�^���ł��̊֐����Ăяo���ăQ�[���X�^�[�g�H
    public void gameStart()
    {
        flag_start = true;
    }


}

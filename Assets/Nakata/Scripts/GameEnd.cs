using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameEnd : MonoBehaviour
{
    public bool flag_gameEnd;//true.�Q�[���G���h�@false.��Q�[���G���h
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

    //�Q�[���G���h���̏����@�Q�[���G���h�ł��̏������Ăяo��
    public void gameEnd()
    {
        flag_gameEnd = true;
        Debug.Log("�Q�[���G���h");
        //�Q�[���G���h���̏���
        //�X�R�A�\��
        //���g���C�{�^���̕\��
        RetryButton.SetActive(true);

    }

    

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using Cinemachine;


public class GameEnd : MonoBehaviour
{
    public bool flag_gameEnd;//true.�Q�[���G���h�@false.��Q�[���G���h
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

    //�Q�[���G���h���̏����@�Q�[���G���h�ł��̏������Ăяo��
    public void gameEnd()
    {
        flag_gameEnd = true;
        Debug.Log("�Q�[���G���h");

        //���g���C�{�^���̕\��
        RetryButton.SetActive(true);

        //�X�R�A�\��
        CountMeter.rectTransform.anchoredPosition=new Vector2(0,0);
        CountMeter.fontSize = 128;
        //


        //�Ō�̃J�����̈���
        Vcam.Priority = 2;
        Vcam.transform.position = new Vector3(0,tarObj.transform.position.y,tarObj.transform.position.y*1.5f);
    }

    

}

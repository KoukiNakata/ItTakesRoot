using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameEnd : MonoBehaviour
{
    public bool flag_gameEnd;//true.�Q�[���G���h�@false.��Q�[���G���h
    [SerializeField] GameObject RetryButton;
    [SerializeField] TextMeshProUGUI CountMeter;
    public AudioClip clearSound;//�n���_
    AudioSource audioSource;

    // Start is called before the first frame update
    void Start()
    {
        flag_gameEnd = false;
        audioSource = GetComponent<AudioSource>();//�n���_
    }

    // Update is called once per frame
    void Update()
    {
      
    }

    //�Q�[���G���h���̏����@�Q�[���G���h�ł��̏������Ăяo��
    public void gameEnd()
    {
        if(!flag_gameEnd)
        {
            flag_gameEnd = true;
            Debug.Log("�Q�[���G���h");

            //���g���C�{�^���̕\��
            RetryButton.SetActive(true);

            //�X�R�A�\��
            CountMeter.rectTransform.anchoredPosition = new Vector2(0, 0);
            CountMeter.fontSize = 128;
            //

            //SE
            audioSource.Stop();//�n���_
            audioSource.PlayOneShot(clearSound);
        }
        

    }

    

}

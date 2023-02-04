using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameStart : MonoBehaviour
{
    public bool flag_start;//true.�Q�[����ԁ@false.��Q�[�����
    public AudioClip title;
    public AudioClip startClick;
    public AudioClip main;
    AudioSource audioSource;
    [SerializeField] GameObject startButton;
    [SerializeField] GameObject CountMeter;
    [SerializeField] GameObject NutritionBar;
    [SerializeField] GameObject Teamlogo;
    [SerializeField] GameObject Gamelogo;
    

    // Start is called before the first frame update
    void Start()
    {
        flag_start = false;
        startButton.SetActive(true);
        CountMeter.SetActive(false);
        NutritionBar.SetActive(false);
        Teamlogo.SetActive(true);
        Gamelogo.SetActive(true);
        audioSource = GetComponent<AudioSource>();
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

    public void titmeMusic()
    {
        audioSource.clip = main;
        audioSource.Play();
    }

    //�{�^���ł��̊֐����Ăяo���ăQ�[���X�^�[�g�H
    public void gameStart()
    {
        flag_start = true;
        startButton.SetActive(false);
        CountMeter.SetActive(true);
        NutritionBar.SetActive(true);
        Teamlogo.SetActive(false);
        Gamelogo.SetActive(false);

        //SE
        //audioSource.Stop();
        audioSource.PlayOneShot(startClick);
    }


}

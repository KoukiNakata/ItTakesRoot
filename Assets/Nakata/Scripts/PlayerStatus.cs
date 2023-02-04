using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStatus : MonoBehaviour
{
    [SerializeField] GameStart gameStart;
    [SerializeField] GameEnd gameEnd;

    public float nutritionVal;//�h�{�̒l
    [SerializeField] float decreaseVal;//�h�{������l
    [SerializeField] float increaseVal;//�h�{��������l

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        //�h�{�̌���
        if(gameStart.flag_start&&!gameEnd.flag_gameEnd) nutritionVal -= decreaseVal*Time.deltaTime;
        

        //�h�{���s�������Q�[���G���h
        if(nutritionVal<=0) gameEnd.gameEnd();
        
    }


    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "nutorition") nutritionVal += increaseVal;
    }
}

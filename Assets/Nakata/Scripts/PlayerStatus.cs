using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStatus : MonoBehaviour
{
    [SerializeField] GameStart gameStart;
    [SerializeField] GameEnd gameEnd;

    public float nutritionVal;//‰h—{‚Ì’l
    [SerializeField] float decreaseVal;//‰h—{‚ªŒ¸‚é’l
    [SerializeField] float increaseVal;//‰h—{‚ª‘‚¦‚é’l

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        //‰h—{‚ÌŒ¸­
        if(gameStart.flag_start&&!gameEnd.flag_gameEnd) nutritionVal -= decreaseVal*Time.deltaTime;
        

        //‰h—{‚ªs‚«‚½ƒQ[ƒ€ƒGƒ“ƒh
        if(nutritionVal<=0) gameEnd.gameEnd();
        
    }


    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "nutorition") nutritionVal += increaseVal;
    }
}

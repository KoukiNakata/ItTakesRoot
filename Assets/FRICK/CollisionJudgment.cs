using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionJudgment : MonoBehaviour
{
    [SerializeField] PlayerStatus PlayerStatus;
    [SerializeField] GameEnd gameEnd;
    // 衝突の瞬間判定
	void OnCollisionEnter(Collision other)
	{
        if(other.gameObject.name == ("obstacle_rock" + "(Clone)"))
        {
            if( other.gameObject.transform.position.y < Camera.main.transform.position.y  )
            {
                gameEnd.gameEnd();
                Destroy(other.gameObject);
            }
        }
        else if(other.gameObject.name == ("PowerUpContainerGreen" + "(Clone)"))
        {
            if( other.gameObject.transform.position.y < Camera.main.transform.position.y  )
            {
                PlayerStatus.nutritionVal += 3;
                Destroy(other.gameObject);
            }
        }
        Debug.Log (other.gameObject.name + "Enter");
	}
}

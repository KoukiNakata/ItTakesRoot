using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionJudgment : MonoBehaviour
{
    // 衝突の瞬間判定
	void OnCollisionEnter(Collision other)
	{
        if(other.gameObject.name == ("obstacle_rock" + "(Clone)"))
        {
            GameObject Gamedirector = GameObject.Find("Gamedirector");

            if( other.gameObject.transform.position.y < Camera.main.transform.position.y  )
            {
                Gamedirector.GetComponent<GameEnd>().gameEnd();
                Destroy(other.gameObject);
            }
        }


        Debug.Log (other.gameObject.name + "Enter");
	}

	// 衝突中の判定
	void OnCollisionStay(Collision other)
	{
		//Debug.Log (other.gameObject.name + "Stay");
	}

	// 衝突離脱の判定
	void OnCollisionExit(Collision other)
	{
		//Debug.Log (other.gameObject.name + "Exit");
	}
}

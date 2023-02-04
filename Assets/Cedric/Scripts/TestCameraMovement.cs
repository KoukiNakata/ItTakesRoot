using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestCameraMovement : MonoBehaviour
{
    public Transform target;
    public float offset;
     Vector3 tempVec3 = new Vector3();

    void LateUpdate() 
    {
        //moving the camera on y axis with root - offset
        tempVec3.y = target.position.y - offset;
        tempVec3.x = this.transform.position.x;
        tempVec3.z = this.transform.position.z;
        this.transform.position = tempVec3;
    }
}

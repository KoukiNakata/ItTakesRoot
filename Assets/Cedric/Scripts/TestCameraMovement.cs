using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestCameraMovement : MonoBehaviour
{
    public Transform target;
    public Vector3 offset;
    //public float CameraMoveSpeed = -5;
    
    void Update()
    {
        transform.position = target.position + offset;
       
        //transform.position += transform.up * CameraMoveSpeed * Time.deltaTime;
    }
}

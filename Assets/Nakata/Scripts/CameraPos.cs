using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class CameraPos : MonoBehaviour
{
    [SerializeField] CinemachineVirtualCamera Cam;
    [SerializeField] GameObject targetObj;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Cam.transform.position = targetObj.transform.position;
    }
}

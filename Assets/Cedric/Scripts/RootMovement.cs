using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RootMovement : MonoBehaviour
{
    //initializing variables
    public float MoveSpeed = 5f;
    public float RootSpeed = 5;
    public int Gap = 10;
    public Vector3 rightRotation;
    public Vector3 leftRotation;
    public Vector3 preRotation;
    public GameObject BodyRoot;
    private List<GameObject>BodyParts = new List<GameObject>();
    private List<Vector3> PositionsHistory = new List<Vector3>();
    private bool rightRotationCheck = true;


    //Decides amount of bodyparts
    void Start()
    {
        GrowRoot();
        GrowRoot();
        GrowRoot();
        GrowRoot();
        GrowRoot();
        GrowRoot();
        GrowRoot();
        GrowRoot();
        GrowRoot();
        GrowRoot();
        GrowRoot();
        GrowRoot();
        GrowRoot();
        GrowRoot();
        GrowRoot();
        GrowRoot();

    }

    // Update is called once per frame
    void Update()
    {
       
        
        //Rotate root
        if (Input.GetMouseButtonDown(0))
        {
            if (rightRotationCheck == true)
            {
                transform.localEulerAngles = rightRotation;
                rightRotationCheck = rightRotationCheck = false;
                print ("Rotated");
            }
            else if (rightRotationCheck == false)
            {
                transform.localEulerAngles = leftRotation;
                rightRotationCheck = rightRotationCheck = true;
                print ("Also Rotated");
            }
        

        }    
    }


    void FixedUpdate()
    {

        //move downward
        transform.position += transform.up * MoveSpeed * Time.deltaTime;
        //Store position history
        PositionsHistory.Insert(0, transform.position);
        //move body parts
        int index = 0;
        foreach (var body in BodyParts) {
            Vector3 point = PositionsHistory[Mathf.Min(index * Gap, PositionsHistory.Count - 1)];
            Vector3 moveDirection = point - body.transform.position;
            body.transform.position += moveDirection * RootSpeed * Time.fixedDeltaTime;
            body.transform.localEulerAngles = preRotation;
            body.transform.LookAt(point, preRotation);
            index ++;

        }

    


    }
    private void GrowRoot()
    {
        //Spawn bodyparts
        GameObject body = Instantiate(BodyRoot);
        BodyParts.Add(body);
    }

    
}

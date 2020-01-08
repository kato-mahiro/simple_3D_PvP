using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShotFireball : MonoBehaviour
{
    private Vector3 PlayerPosition;
    // Use this for initialization
    void Start()
    {

    }

    void Update()
    {
        GameObject obj = (GameObject)Resources.Load("FireBall");
        if (Input.GetKeyDown(KeyCode.F))
        {
            GameObject firepoint = GameObject.Find("FirePoint");
            Instantiate(obj, firepoint.transform.position , Quaternion.Euler(0,transform.rotation.eulerAngles.y ,0));
            //Instantiate(obj, firepoint.transform.position , transform.Rotate(transform.right, 45));
        }
    }
}

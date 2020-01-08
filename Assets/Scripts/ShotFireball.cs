using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShotFireball : MonoBehaviour
{
    GameObject refObj;
    private Vector3 PlayerPosition;
    // Use this for initialization
    void Start()
    {

    }

    void Update()
    {
        refObj = GameObject.Find("HPctrl");
        UIDirector hoge = refObj.GetComponent<UIDirector>();
        GameObject obj = (GameObject)Resources.Load("FireBall");
        if (Input.GetKeyDown(KeyCode.F))
        {
            if(hoge.sp > 0.3)
            {
                GameObject firepoint = GameObject.Find("FirePoint");
                Instantiate(obj, firepoint.transform.position , Quaternion.Euler(0,transform.rotation.eulerAngles.y ,0));
                hoge.minus();
                //Instantiate(obj, firepoint.transform.position , transform.Rotate(transform.right, 45));
            }
        }
    }
}

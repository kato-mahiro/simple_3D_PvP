﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShotFireball2 : MonoBehaviour
{
    public AudioClip sound1;
    AudioSource audioSource;
    GameObject refObj;
    private Vector3 PlayerPosition;
    // Use this for initialization
    void Start()
    {
        audioSource = GetComponent<AudioSource>();

    }

    void Update()
    {
        refObj = GameObject.Find("BarCtrl");
        UIDirector hoge = refObj.GetComponent<UIDirector>();
        GameObject obj = (GameObject)Resources.Load("FireBall");
        if (Input.GetKeyDown(KeyCode.P))
        {
            if(hoge.sp2 > 0.3)
            {
                audioSource.PlayOneShot(sound1);
                GameObject firepoint = GameObject.Find("FirePoint2");
                Instantiate(obj, firepoint.transform.position , Quaternion.Euler(0,transform.rotation.eulerAngles.y ,0));
                hoge.minus2();
                //Instantiate(obj, firepoint.transform.position , transform.Rotate(transform.right, 45));
            }
        }
    }
}
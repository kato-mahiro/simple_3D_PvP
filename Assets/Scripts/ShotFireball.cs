using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShotFireball : MonoBehaviour
{
    public AudioClip sound1;
    public CharacterController CC;
    AudioSource audioSource;
    GameObject refObj;
    private Vector3 PlayerPosition;
    // Use this for initialization
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }
    
    void Restart()
    {
        CC.enabled = true;
    }

    void Update()
    {
        refObj = GameObject.Find("BarCtrl");
        UIDirector hoge = refObj.GetComponent<UIDirector>();
        GameObject obj = (GameObject)Resources.Load("FireBall");
        if (Input.GetButtonDown("Fire1"))
        {
            if(hoge.sp > 0.3)
            {
                audioSource.PlayOneShot(sound1);
                GameObject firepoint = GameObject.Find("FirePoint");
                Instantiate(obj, firepoint.transform.position , Quaternion.Euler(0,transform.rotation.eulerAngles.y ,0));
                hoge.minus();
                //Instantiate(obj, firepoint.transform.position , transform.Rotate(transform.right, 45));
                CC=CC.GetComponent<CharacterController>();
                //CC.enabled = false;

                //Invoke("Restart", 1.0f);
            }
        }
    }
}

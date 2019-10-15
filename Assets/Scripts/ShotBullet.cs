using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShotBullet : MonoBehaviour
{
    private Vector3 PlayerPosition;
    // Use this for initialization
    void Start()
    {

    }

    void Update()
    {
        GameObject obj = (GameObject)Resources.Load("Bullet");
        if (Input.GetKeyDown(KeyCode.F))
        {
            Debug.Log(transform.rotation.eulerAngles.y);
            //Instantiate(obj, new Vector3(0.0f, 2.0f, 0.0f), Quaternion.identity);
            PlayerPosition = transform.position;
            Instantiate(obj, PlayerPosition, Quaternion.Euler(90,transform.rotation.eulerAngles.y ,0));

        }

    }
}
